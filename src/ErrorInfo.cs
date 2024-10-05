using System;

namespace HugeJSONViewer
{
    internal class ErrorInfo<T>
    {
        /// <summary>
        /// Return value of the method, if no error occurred
        /// </summary>
        internal T Value { get; set; }

        /// <summary>
        /// Proposed exit code of the application
        /// </summary>
        internal ExitCode ExitCode { get; set; } = ExitCode.Success;

        /// <summary>
        /// Exception information, if an error occurred
        /// </summary>
        internal Exception Exception { get; set; }

        /// <summary>
        /// Proposed message for the user
        /// </summary>
        internal string Message { get; set; }

        internal bool HasError => ExitCode != ExitCode.Success || Exception != null;
    }
}