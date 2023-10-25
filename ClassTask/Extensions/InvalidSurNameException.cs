using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Extensions
{
    internal class InvalidSurNameException : Exception
    {
        public InvalidSurNameException() { }
        public InvalidSurNameException(string message) : base(message) { }
    }
}
