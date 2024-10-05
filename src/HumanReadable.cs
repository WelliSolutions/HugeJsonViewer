using System;
using HugeJSONViewer.Properties;

namespace HugeJSONViewer
{
    /// <summary>
    /// Helper class for formatting data for humans
    /// </summary>
    static class HumanReadable
    {
        public static string Time(long timeMilliseconds)
        {
            var span = TimeSpan.FromMilliseconds(timeMilliseconds);
            return string.Format(Resources.HumanReadableTime ,(int)span.TotalMinutes,span.Seconds,span.Milliseconds);
        }

        private static readonly double kB = 1024.0;
        private static readonly double MB = kB * 1024;
        private static readonly double GB = MB * 1024;

        public static string FileSize(long sizeInBytes)
        {
            if (sizeInBytes >= GB)
            {
                return string.Format(Resources.HumanReadableGB, sizeInBytes/GB);
            }
            if (sizeInBytes >= MB)
            {
                return string.Format(Resources.HumanReadableMB, sizeInBytes / MB);
            }
            return string.Format(Resources.HumanReadableKB, sizeInBytes / kB);
        }
    }
}
