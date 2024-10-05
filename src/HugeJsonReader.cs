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
        private static readonly int ESTIMATED_MEMORY_FACTOR = 7;

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
                    Message = string.Format(Resources.InvalidFileName, filename, ex.Message)
                };
            }

            // File existence check
            if (!file.Exists)
            {
                return new ErrorInfo<FileInfo>
                {
                    Message = string.Format(Resources.FileNotFound, filename),
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
                    Resources.PerformanceWarning,
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
                    Message = string.Format(Resources.ErrorParsingJson, fileInfo.FullName, ex.Message),
                    ExitCode = ExitCode.JsonFormatException
                };
            }
            catch (Exception ex)
            {
                return new ErrorInfo<PerformanceInfo<JContainer>>
                {
                    Message = string.Format(Resources.ErrorAccessingFile, fileInfo.FullName, ex.Message),
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
