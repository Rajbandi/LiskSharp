using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Common
{
    [DataContract]
    public class DappAsset :Asset
    {
        [DataMember(Name = "dapp")]
        public Dapp Dapp { get; set; }

        public override byte[] GetBytes()
        {
            return Dapp.GetBytes();
        }
    }
}
