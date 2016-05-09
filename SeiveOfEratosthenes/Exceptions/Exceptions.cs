using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace SieveOfEratosthenes.Exceptions
{
    [Serializable]
    public class RangeInvalidException : Exception
    {
        public RangeInvalidException()
        {
        }

        public RangeInvalidException(string message) : base(message)
        {
        }

        public RangeInvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RangeInvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public class ListEmptyException : Exception
    {
        public ListEmptyException()
        {
        }

        public ListEmptyException(string message) : base(message)
        {

        }

        public ListEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ListEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
