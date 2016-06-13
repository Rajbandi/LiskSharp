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
