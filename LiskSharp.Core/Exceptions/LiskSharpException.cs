#region copyright
// <copyright file="LiskSharpException.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
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
