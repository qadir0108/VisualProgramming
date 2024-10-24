using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    public class InvalidPinException : Exception
    {
        public InvalidPinException() { }
        public InvalidPinException(string message) : base(message) { }
        public InvalidPinException(string message, Exception inner) : base(message, inner) { }
        protected InvalidPinException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
