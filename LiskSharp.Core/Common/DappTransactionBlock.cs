using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Common
{
    [DataContract]
    public class DappTransactionBlock
    {
        [DataMember(Name = "block")]
        public Block Block { get; set; }

        [DataMember(Name = "dapp")]
        public Transaction Dapp { get; set; }
    }
}
