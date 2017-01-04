using System;
using System.Runtime.Serialization;

namespace Ron.WPF
{
    [Serializable]
    public class AppsException : Exception
    {
        public AppsException()
        {
        }

        public AppsException(string message)
            : base(message)
        {
        }

        public AppsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected AppsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}