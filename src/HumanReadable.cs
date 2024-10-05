using System;

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
            return $"{(int)span.TotalMinutes}:{span.Seconds:00}.{span.Milliseconds:000} min";
        }

        private static readonly double kB = 1024.0;
        private static readonly double MB = kB * 1024;
        private static readonly double GB = MB * 1024;

        public static string FileSize(long sizeInBytes)
        {
            if (sizeInBytes >= GB)
            {
                return $"{sizeInBytes/GB:0.000} GB";
            }
            if (sizeInBytes >= MB)
            {
                return $"{sizeInBytes/MB:0.000} MB";
            }
            return $"{sizeInBytes/kB:0.000} kB";
        }
    }
}
