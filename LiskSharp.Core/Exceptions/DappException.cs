using System;

namespace LiskSharp.Core.Exceptions
{
    public class DappException : Exception
    {
        public DappException() 
        {
            
        }

        public DappException(string message) : base(message)
        {
            
        }

        public DappException(string message, Exception inner) : base(message, inner)
        {
            
        }
    }
}
