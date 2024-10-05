using System;

namespace HugeJSONViewer.Hacks
{
    /// <summary>
    /// Contains the pertinent data for a ProgressStream Report event.
    /// </summary>
    public class ProgressStreamReportEventArgs : EventArgs
    {
        /// <summary>
        /// The number of bytes that were read/written to/from the stream.
        /// </summary>
        public int BytesMoved { get; internal set; }

        /// <summary>
        /// The total length of the stream in bytes.
        /// </summary>
        public long StreamLength { get; internal set; }

        /// <summary>
        /// The current position in the stream.
        /// </summary>
        public long StreamPosition { get; internal set; }

        /// <summary>
        /// True if the bytes were read from the stream, false if they were written.
        /// </summary>
        public bool WasRead { get; internal set; }

        /// <summary>
        /// Default constructor for ProgressStreamReportEventArgs.
        /// </summary>
        public ProgressStreamReportEventArgs()
            : base()
        {
        }

        /// <summary>
        /// Creates a new ProgressStreamReportEventArgs initializing its members.
        /// </summary>
        /// <param name="bytesMoved">The number of bytes that were read/written to/from the stream.</param>
        /// <param name="streamLength">The total length of the stream in bytes.</param>
        /// <param name="streamPosition">The current position in the stream.</param>
        /// <param name="wasRead">True if the bytes were read from the stream, false if they were written.</param>
        /// <param name="totalBytes"></param>
        public ProgressStreamReportEventArgs(int bytesMoved, long streamLength, long streamPosition, bool wasRead, int totalBytes = 0)
            : this()
        {
            BytesMoved = bytesMoved;
            StreamLength = streamLength;
            StreamPosition = streamPosition;
            WasRead = WasRead;
            TotalBytes = totalBytes;
        }

        public int TotalBytes { get; internal set; }
    }
}