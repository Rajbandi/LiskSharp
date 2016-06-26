#region copyright
// <copyright file="AccountHelper.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
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
