using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace HugeJSONViewer
{
    public class HierarchicalJObject
    {
        private static int _totalObjectCount;
        private JToken _jToken;
        private readonly IList<HierarchicalJObject> _dataSource;
        private readonly int _id;
        static int _devExpressReflectionCount;

        internal delegate void ProgressDelegate(int progress);

        internal static event ProgressDelegate OnProgress;

        internal HierarchicalJObject(IList<HierarchicalJObject> dataSource)
        {
            _id = Interlocked.Increment(ref _totalObjectCount);
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

        public int ParentID {
            // ReSharper disable once UnusedMember.Global
            // Justification: used by DevExpress via reflection
            get;
            set;
        }

        public JToken Token
        {
            get => _jToken;
            set
            {
                _jToken = value;
                Wrap(this);
            }
        }

        // ReSharper disable once UnusedMember.Global
        // Justification: used by DevExpress via reflection
        public string Path
        {
            get
            {
                if (Token.Parent == null)
                {
                    return "NDJSON";
                }
                switch (Token.Parent?.Type)
                {
                    case JTokenType.Property:
                        return ((JProperty)(Token.Parent)).Name;
                    case JTokenType.Array:
                        return "[" + ((JArray)(Token.Parent)).IndexOf(Token)+ "]";
                }
                var startIndex = Token.Parent?.Parent?.Path.Length;
                var path = Token.Path.Substring(startIndex??0).Trim('.');
                return path;
            }
        }

        // ReSharper disable once UnusedMember.Global
        // Justification: used by DevExpress via reflection
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

        private void Wrap(HierarchicalJObject parent)
        {
            void AddChild(JToken childToken)
            {
                var child = new HierarchicalJObject(_dataSource)
                {
                    ParentID = parent.ID,
                    Token = childToken,
                };
                _dataSource.Add(child);
            }

            foreach (var child in parent.Token.Children())
            {
                switch (child)
                {
                    case JProperty { Value: JContainer jContainer }:
                        AddChild(jContainer);
                        break;
                    case JProperty jProperty:
                        AddChild(jProperty.Value);
                        break;
                    case JObject jObject:
                        AddChild(jObject);
                        break;
                }
            }
        }

        public static void ResetProgress()
        {
            Interlocked.Exchange(ref _devExpressReflectionCount, 0);
        }
    }
}