using System;

namespace RleLwzCompressionLibrary.Exceptions
{
    public class PresenterException : Exception
    {
        public PresenterException() { }

        public PresenterException(string message) : base(message) { }

        public PresenterException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
