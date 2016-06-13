using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Common
{
    public enum TransactionType
    {
        Send = 0,
        Signature = 1,
        Delegate = 2,
        Vote = 3,
        Multi = 4,
        Dapp = 5,
        InTransfer = 6,
        OutTransfer = 7

    }
}
