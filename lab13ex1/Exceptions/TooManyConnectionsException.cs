using System.Runtime.Serialization;

namespace lab13ex1.Exceptions
{
    [Serializable]
    internal class TooManyConnectionsException : Exception
    {
        public TooManyConnectionsException()
        {
        }

        public TooManyConnectionsException(string? message) : base(message)
        {
        }

        public TooManyConnectionsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TooManyConnectionsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}