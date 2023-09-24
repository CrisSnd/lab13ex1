using System.Runtime.Serialization;

namespace lab13ex1.Exceptions
{
    [Serializable]
    internal class TooManyCardtException : Exception
    {
        public TooManyCardtException()
        {
        }

        public TooManyCardtException(string? message) : base(message)
        {
        }

        public TooManyCardtException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TooManyCardtException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}