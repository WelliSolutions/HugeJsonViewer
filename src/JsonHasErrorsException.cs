using System;

namespace HugeJSONViewer
{
    internal class JsonHasErrorsException : Exception
    {
        public JsonHasErrorsException(string message):base(message)
        {
        }
    }
}