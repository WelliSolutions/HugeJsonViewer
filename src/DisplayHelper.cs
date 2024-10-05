using System;
using Newtonsoft.Json.Linq;

namespace HugeJSONViewer
{
    /// <summary>
    /// Helper class for formatting parse times
    /// </summary>
    static class DisplayHelper
    {
        public static string HumanReadable(long timeMilliseconds)
        {
            var span = TimeSpan.FromMilliseconds(timeMilliseconds);
            int minutes = (int) span.TotalMinutes;
            span = span.Subtract(TimeSpan.FromMinutes(minutes));
            int seconds = (int) span.TotalSeconds;
            span = span.Subtract(TimeSpan.FromSeconds(seconds));
            int ms = span.Milliseconds;
            return $"{minutes}:{seconds:00}.{ms:000} min";
        }

        /// <summary>
        /// Constant for converting file sizes
        /// </summary>
        private const float kB = 1024.0f;
        private const float MB = kB * 1024;
        private const float GB = MB * 1024;

        public static string FileSize(long sizeInBytes)
        {
            if (sizeInBytes >= GB)
            {
                return (sizeInBytes/GB).ToString("0.000 GB");
            }
            if (sizeInBytes >= MB)
            {
                return (sizeInBytes/MB).ToString("0.000 MB");
            }
            return (sizeInBytes / kB).ToString("0.000 kB");
        }

        internal static string FormatToken(HierarchicalJObject node)
        {
            if (node.Object is JObject) return "{} Object";
            if (node.Object is JProperty) return "Property";

            if (node.Object is JArray)
            {
                var array = (JArray)node.Object;
                return  "[], size " + array.Count;
            }

            if (node.Object is JValue)
            {
                var jValue = (JValue)node.Object;
                if (jValue.Type == JTokenType.String)
                {
                    string s = (string) jValue.Value;
                    if (s.Length <= 16)
                    {
                        return jValue.Type + " = " + jValue.Value;
                    }
                    return jValue.Type + " = " + s.Substring(0,16)+ " ...";
                }
                return jValue.Type +" = "+  jValue.Value;
            }

            return node.Object.GetType().ToString();
        }
    }
}
