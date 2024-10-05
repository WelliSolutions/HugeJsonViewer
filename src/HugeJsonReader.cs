using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using HugeJSONViewer.Hacks;
using HugeJSONViewer.Properties;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HugeJSONViewer
{
    class HugeJsonReader
    {
        /// <summary>
        /// Experimentally found overhead factor between JSON file size and
        /// used RAM for processing and displaying such a file.
        /// </summary>
        private static int ESTIMATED_MEMORY_FACTOR = 7;

        private static readonly long RESERVED_MEMORY_FOR_OS = 1.GBToBytes();


        internal ErrorInfo<FileInfo> OpenFile(string filename)
        {

            // File name consistency check
            FileInfo file;
            try
            {
                file = new FileInfo(filename);
            }
            catch (Exception ex)
            {
                return new ErrorInfo<FileInfo>
                {
                    ExitCode = ExitCode.InvalidFileName,
                    Exception = ex,
                    Message = $"Invalid file name: {filename}\r\n{ex.Message}"
                };
            }

            // File existence check
            if (!file.Exists)
            {
                return new ErrorInfo<FileInfo>
                {
                    Message = $"File not found: {filename}",
                    ExitCode = ExitCode.FileNotFound,
                };
            }

            // File size / performance check
            ulong estimatedRequiredRam = (ulong)(file.Length * ESTIMATED_MEMORY_FACTOR);
            var physicalRam = new ComputerInfo().TotalPhysicalMemory - (ulong) RESERVED_MEMORY_FOR_OS;
            if (estimatedRequiredRam > physicalRam)
            {
                var answer = MessageBox.Show(
                    string.Format(Resources.FileTooLargeWarning, HumanReadable.FileSize(file.Length)),
                    "Performance warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (answer == DialogResult.No)
                {
                    return new ErrorInfo<FileInfo>
                    {
                        ExitCode = ExitCode.PerformanceRejectedByUser
                    };
                }
            }

            return new ErrorInfo<FileInfo>
            {
                Value = file
            };
        }

        internal ErrorInfo<PerformanceInfo<JContainer>> Deserialize(FileInfo fileInfo, Action<string> progress)
        {
            JContainer json;
            long parseTimeMilliseconds;
            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                json = new JsonHelper().DeserializeViaStream(fileInfo.FullName, progress);
                stopwatch.Stop();
                parseTimeMilliseconds = stopwatch.ElapsedMilliseconds;
            }
            catch (JsonReaderException ex)
            {
                return new ErrorInfo<PerformanceInfo<JContainer>>
                {
                    Exception = ex,
                    Message = $"Error parsing JSON: {fileInfo.FullName}\r\n{ex.Message}",
                    ExitCode = ExitCode.JsonFormatException
                };
            }
            catch (Exception ex)
            {
                return new ErrorInfo<PerformanceInfo<JContainer>>
                {
                    Message = $"Error accessing file: {fileInfo.FullName}\r\n{ex.Message}",
                    Exception = ex,
                    ExitCode = ExitCode.FileAccessError
                };
            }

            return new ErrorInfo<PerformanceInfo<JContainer>>
            {
                Value = new PerformanceInfo<JContainer>
                {
                    ElapsedMilliseconds = parseTimeMilliseconds,
                    Value = json
                },

            };
        }
    }
}
