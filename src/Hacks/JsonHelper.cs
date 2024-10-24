﻿using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using HugeJSONViewer.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HugeJSONViewer
{
    class DeserializationResult
    {
        public JContainer Data;
        public bool ReachedEndOfStream;
        public bool IsNdJson;
    }
    class JsonHelper
    {
        public DeserializationResult DeserializeViaStream(string filename, Action<string> progress)
        {
            _progress = progress;
            var serializer = new JsonSerializer();
            var result = new DeserializationResult();


            using var fileStream = new FileStream(filename, FileMode.Open);
            using var progressStream = new ProgressStream(fileStream);
            progressStream.BytesRead += OnStreamProgress;
            using (var sr =new StreamReader(progressStream))
            {
                using (var jsonTextReader = new JsonTextReader(sr))
                {
                    jsonTextReader.SupportMultipleContent = true;
                    var d = serializer.Deserialize(jsonTextReader);
                    result.Data = (JContainer)d;
                    // jsonTextReader.Read(); // Workaround for https://github.com/JamesNK/Newtonsoft.Json/issues/2991
                    result.ReachedEndOfStream = IsEndOfStream(jsonTextReader);
                    var ndjson = new JArray { result.Data };
                    while (!result.ReachedEndOfStream)
                    {
                        var next = serializer.Deserialize(jsonTextReader);
                        ndjson.Add(next);
                        result.Data = ndjson;
                        result.IsNdJson = true;
                        result.ReachedEndOfStream = IsEndOfStream(jsonTextReader);
                    }
                }
            }
            progressStream.BytesRead -= OnStreamProgress;

            return result;
        }

        private static bool IsEndOfStream(JsonTextReader jsonTextReader)
        {
            try
            {
                if (jsonTextReader.Read())
                {
                    return false;
                }
            }
            catch (JsonReaderException jre)
            {
                return false;
            }

            return true;
        }

        private int _nextProgressAt;
        private Action<string> _progress;

        private void OnStreamProgress(object sender, ProgressStreamReportEventArgs args)
        {
            if (_nextProgressAt == args.TotalBytes/1.MBToBytes())
            {                
                _progress(string.Format(Resources.StreamingProgress, HumanReadable.FileSize(args.TotalBytes), HumanReadable.FileSize(args.StreamLength)));
                Interlocked.Increment(ref _nextProgressAt);
                Application.DoEvents();
            }
        }
    }
}
