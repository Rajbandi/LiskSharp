using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using NBitcoin.Protocol;

namespace LiskSharp.Core.Common
{
 
    public abstract class Asset : IAsset
    {
        public abstract byte[] GetBytes();
    }
}
