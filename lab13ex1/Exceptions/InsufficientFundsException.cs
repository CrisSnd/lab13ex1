using System.Runtime.Serialization;

namespace lab13ex1.Exceptions
{
    [Serializable]
    internal class InsufficientFundsException : Exception
    {
        public InsufficientFundsException()
        {
        }

        public InsufficientFundsException(string? message) : base(message)
        {
        }

        public InsufficientFundsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InsufficientFundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}