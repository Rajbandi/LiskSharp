using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskSharp.Core.Extensions;

namespace LiskSharp.Core.Common
{
    public class KeyPair
    {
        public byte[] PublicKey { get; set; }

        public byte[] PrivateKey { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("Public Key : {0}", PublicKey != null ? PublicKey.ToHex() : "");
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("Private Key : {0}", PrivateKey != null ? PrivateKey.ToHex() : "");
            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }
    }
}
