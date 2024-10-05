using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HugeJSONViewer.Hacks
{
    class JsonHelper
    {
        public JContainer DeserializeViaStream(string filename, Action<string> progress)
        {
            _progress = progress;
            object obj;
            var serializer = new JsonSerializer();


            using (var fileStream = new FileStream(filename, FileMode.Open))
            {
                using (var progressStream = new ProgressStream(fileStream))
                {
                    progressStream.BytesRead += OnStreamProgress;
                    using (var sr =new StreamReader(progressStream))
                    {
                        using (var jsonTextReader = new JsonTextReader(sr))
                        {
                            obj = serializer.Deserialize(jsonTextReader);
                        }
                    }
                    progressStream.BytesRead -= OnStreamProgress;
                }
            }

            return (JContainer) obj;
        }

        private int _mbread;
        private Action<string> _progress;

        private void OnStreamProgress(object sender, ProgressStreamReportEventArgs args)
        {
            if (_mbread == args.TotalBytes/1.MBToBytes())
            {                
                _progress($"{_mbread}/{args.StreamLength.BytesToMB()} MB");
                Interlocked.Increment(ref _mbread);
                Application.DoEvents();
            }
        }
    }
}
