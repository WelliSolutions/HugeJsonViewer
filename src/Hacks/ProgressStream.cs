using System;
using System.IO;

namespace HugeJSONViewer.Hacks
{
    /// <summary>
    /// Wraps another stream and provides reporting for when bytes are read or written to the stream.
    /// </summary>
    public class ProgressStream : Stream
    {
        private readonly Stream _innerStream;
        private int _totalBytesRead;
        private int _totalBytesWritten;

        /// <summary>
        /// Creates a new ProgressStream supplying the stream for it to report on.
        /// </summary>
        /// <param name="streamToReportOn">The underlying stream that will be reported on when bytes are read or written.</param>
        public ProgressStream(Stream streamToReportOn)
        {
            if (streamToReportOn != null)
            {
                _innerStream = streamToReportOn;
            }
            else
            {
                throw new ArgumentNullException(nameof(streamToReportOn));
            }
        }

        /// <summary>
        /// Raised when bytes are read from the stream.
        /// </summary>
        public event ProgressStreamReportDelegate BytesRead;

        /// <summary>
        /// Raised when bytes are written to the stream.
        /// </summary>
        public event ProgressStreamReportDelegate BytesWritten;

        /// <summary>
        /// Raised when bytes are either read or written to the stream.
        /// </summary>
        public event ProgressStreamReportDelegate BytesMoved;

        readonly ProgressStreamReportEventArgs _progressEventArgs = new ProgressStreamReportEventArgs();

        protected virtual void OnBytesRead(int bytesMoved)
        {
            if (BytesRead == null) return;
            _progressEventArgs.BytesMoved = bytesMoved;
            _progressEventArgs.StreamLength = Length;
            _progressEventArgs.StreamPosition = _innerStream.Position;
            _progressEventArgs.WasRead = true;
            _progressEventArgs.TotalBytes = _totalBytesRead;
            BytesRead(this, _progressEventArgs);
        }

        protected virtual void OnBytesWritten(int bytesMoved)
        {
            if (BytesWritten == null) return;
            var args = new ProgressStreamReportEventArgs(bytesMoved, Length, _innerStream.Position, false, _totalBytesWritten);
            BytesWritten(this, args);
        }

        protected virtual void OnBytesMoved(int bytesMoved, bool isRead, int total)
        {
            if (BytesMoved == null) return;
            var args = new ProgressStreamReportEventArgs(bytesMoved, Length, _innerStream.Position, isRead, total);
            BytesMoved(this, args);
        }

        public override bool CanRead => _innerStream.CanRead;

        public override bool CanSeek => _innerStream.CanSeek;

        public override bool CanWrite => _innerStream.CanWrite;

        public override void Flush()
        {
            _innerStream.Flush();
        }

        long _length = long.MinValue;

        public override long Length {
            get
            {
                if (_length == long.MinValue)
                {
                    _length = _innerStream.Length;
                }
                return _length;
            }
        }

        public override long Position
        {
            get { return _innerStream.Position; }
            set { _innerStream.Position = value; }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            var bytesRead = _innerStream.Read(buffer, offset, count);

            OnBytesRead(bytesRead);
            _totalBytesRead += bytesRead;
            OnBytesMoved(bytesRead, true, _totalBytesRead);

            return bytesRead;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _innerStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _innerStream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _innerStream.Write(buffer, offset, count);

            OnBytesWritten(count);
            _totalBytesWritten += count;
            OnBytesMoved(count, false, _totalBytesWritten);
        }

        public override void Close()
        {
            _innerStream.Close();
            base.Close();
        }
    }
}