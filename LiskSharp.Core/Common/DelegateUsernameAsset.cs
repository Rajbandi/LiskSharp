using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Common
{
    [DataContract]
    public class DelegateUsernameAsset : Asset
    {
        [DataMember(Name = "delegate")]
        public DelegateUsername Delegate { get; set; }

        public override byte[] GetBytes()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write(Delegate.Username);
                }
                return stream.ToArray();
            }
        }
    }
}
