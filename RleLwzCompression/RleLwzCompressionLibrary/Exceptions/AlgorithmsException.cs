using System;

namespace RleLwzCompressionLibrary.Exceptions
{
    public class AlgorithmsException : Exception
    {
        public AlgorithmsException() { }

        public AlgorithmsException(string message) : base(message) { }

        public AlgorithmsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}