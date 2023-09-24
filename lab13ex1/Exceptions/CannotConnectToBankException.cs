using System.Runtime.Serialization;

namespace lab13ex1.Exceptions
{
    [Serializable]
    internal class CannotConnectToBankException : Exception
    {
        public CannotConnectToBankException()
        {
        }

        public CannotConnectToBankException(string? message) : base(message)
        {
        }

        public CannotConnectToBankException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CannotConnectToBankException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}