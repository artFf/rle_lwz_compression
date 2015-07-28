using System;

namespace RleLwzCompressionLibrary.Exceptions
{
    /// <summary>
    /// Exception handling in classes using the picture
    /// </summary>
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
