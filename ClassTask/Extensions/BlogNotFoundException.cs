using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Extensions
{
    internal class BlogNotFoundException : Exception
    {
        public BlogNotFoundException() { }
        public BlogNotFoundException(string message) : base(message) { }
    }
}
