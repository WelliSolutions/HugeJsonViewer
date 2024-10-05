using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace HugeJSONViewer
{
    public class HierarchicalJObject
    {
        private static int _currentParentId;
        private JToken _jObject;
        private readonly IList<HierarchicalJObject> _dataSource;
        private readonly int _id;
        static int _devExpressReflectionCount;

        internal delegate void ProgressDelegate(int progress);

        internal static event ProgressDelegate OnProgress;

        private static int getID()
        {
            Interlocked.Increment(ref _currentParentId);
            return _currentParentId;
        }

        internal HierarchicalJObject(IList<HierarchicalJObject> dataSource)
        {
            _id = getID();
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

        public JToken Object
        {
            get { return _jObject; }
            set
            {
                _jObject = value;
                Wrap(this);
            }
        }

        // ReSharper disable once UnusedMember.Global
        public string Path
        {
            get
            {
                var startIndex = Object.Parent?.Parent?.Path.Length;
                return Object.Path.Substring(startIndex??0).Trim('.');
            }
        }

        // ReSharper disable once UnusedMember.Global
        public string Value => DisplayHelper.FormatToken(this);

        private void Wrap(HierarchicalJObject h)
        {
            foreach (var child in h.Object.Children())
            {

                //if (!(child is JObject)) continue;
                if (child is JProperty)
                {
                    var jProperty = (JProperty) child;
                    if (jProperty.Value is JContainer)
                    {
                        var jValue = (JContainer) jProperty.Value;
                        var hChild = new HierarchicalJObject(_dataSource)
                        {
                            ParentID = h.ID,
                            Object = jValue,
                        };
                        _dataSource.Add(hChild);
                    }
                    else
                    {
                        var jValue = jProperty.Value;
                        var hChild = new HierarchicalJObject(_dataSource)
                        {
                            ParentID = h.ID,
                            Object = jValue,
                        };
                        _dataSource.Add(hChild);
                    }
                }
                else if (child is JObject)
                {
                    var hChild = new HierarchicalJObject(_dataSource)
                    {
                        ParentID = h.ID,
                        Object = (JContainer) child,
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