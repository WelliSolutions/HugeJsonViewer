namespace HugeJSONViewer
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Converts a number from MB into bytes
        /// </summary>
        /// <param name="value">Value in megabytes</param>
        /// <returns>Value in bytes</returns>
        public static long MBToBytes(this int value)
        {
            return (long) value*1024*1024;
        }

        /// <summary>
        /// Converts a number from GB into bytes
        /// </summary>
        /// <param name="value">Value in megabytes</param>
        /// <returns>Value in bytes</returns>
        public static long GBToBytes(this int value)
        {
            return (long)value * 1024 * 1024 * 1024;
        }
    }
}