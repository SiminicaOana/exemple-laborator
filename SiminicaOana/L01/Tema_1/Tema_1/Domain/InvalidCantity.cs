using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    [Serializable]
    internal class InvalidCantity : Exception
    {
        public InvalidCantity()
        {
        }

        public InvalidCantity(string? message) : base(message)
        {
        }

        public InvalidCantity(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidCantity(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
