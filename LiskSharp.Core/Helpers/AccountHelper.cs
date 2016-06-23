#region copyright
// <copyright file="AccountHelper.cs" >
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
using LiskSharp.Core.Common;

namespace LiskSharp.Core.Helpers
{
    public static class AccountHelper
    {
        public static Account GetAccount(string secret)
        {
            var address = CryptoHelper.GetAddress(secret);
            return new Account
            {
                Address = address
            };
        }

    }
}
