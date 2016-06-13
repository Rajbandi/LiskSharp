using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Exceptions
{
    public class LiskSharpException : Exception
    {
        public LiskSharpException()
        {
            
        }

        public LiskSharpException(string message) : base(message)
        {
            
        }

        public LiskSharpException(string message, Exception inner) : base(message, inner)
        {
            
        }
    }
}
