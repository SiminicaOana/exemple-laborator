using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    [Serializable]
    internal class InvalidProductID : Exception
    {
        public InvalidProductID()
        {
        }

        public InvalidProductID(string? message) : base(message)
        {
        }

        public InvalidProductID(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidProductID(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
