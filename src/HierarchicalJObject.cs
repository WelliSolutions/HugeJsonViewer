using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace HugeJSONViewer
{
    public class HierarchicalJObject
    {
        private static int _currentParentId;
        private JToken _jToken;
        private readonly IList<HierarchicalJObject> _dataSource;
        private readonly int _id;
        static int _devExpressReflectionCount;

        internal delegate void ProgressDelegate(int progress);

        internal static event ProgressDelegate OnProgress;

        internal HierarchicalJObject(IList<HierarchicalJObject> dataSource)
        {
            _id = Interlocked.Increment(ref _currentParentId);
            _dataSource = dataSource;
        }

        public int ID
        {
            get
            {
                int count = Interlocked.Increment(ref _devExpressReflectionCount);
                if (count%1000000 == 0)
                {
                    OnProgress?.Invoke(count);
                }
                return _id;
            }
        }

        public int ParentID { get; set; }

        public JToken Token
        {
            get { return _jToken; }
            set
            {
                _jToken = value;
                Wrap(this);
            }
        }

        // ReSharper disable once UnusedMember.Global
        public string Path
        {
            get
            {
                var startIndex = Token.Parent?.Parent?.Path.Length;
                return Token.Path.Substring(startIndex??0).Trim('.');
            }
        }

        // ReSharper disable once UnusedMember.Global
        public string Value => Token switch
        {
            JObject _ => "{} Object",
            JProperty _ => "Property",
            JArray array => "[], size " + array.Count,
            JValue { Type: JTokenType.String } jValue => jValue.Value switch
            {
                string s when s.Length <= 16 => $"{jValue.Type} = {s}",
                string s => $"{jValue.Type} = {s.Substring(0, 16)} ...",
                _ => $"{jValue.Type}"
            },
            JValue jValue => $"{jValue.Type} = {jValue.Value}",
            _ => Token.GetType().ToString()
        };

        private void Wrap(HierarchicalJObject h)
        {
            foreach (var child in h.Token.Children())
            {

                //if (!(child is JObject)) continue;
                if (child is JProperty jProperty)
                {
                    if (jProperty.Value is JContainer)
                    {
                        var jValue = (JContainer) jProperty.Value;
                        var hChild = new HierarchicalJObject(_dataSource)
                        {
                            ParentID = h.ID,
                            Token = jValue,
                        };
                        _dataSource.Add(hChild);
                    }
                    else
                    {
                        var jValue = jProperty.Value;
                        var hChild = new HierarchicalJObject(_dataSource)
                        {
                            ParentID = h.ID,
                            Token = jValue,
                        };
                        _dataSource.Add(hChild);
                    }
                }
                else if (child is JObject)
                {
                    var hChild = new HierarchicalJObject(_dataSource)
                    {
                        ParentID = h.ID,
                        Token = (JContainer) child,
                    };
                    _dataSource.Add(hChild);
                }
            }
        }

        public static void ResetProgress()
        {
            Interlocked.Exchange(ref _devExpressReflectionCount, 0);
        }
    }
}