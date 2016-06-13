using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LiskSharp.Core.Extensions;

namespace LiskSharp.Core.Common
{
    [DataContract]
    public class DelegatesAsset : Asset
    {
        [DataMember(Name = "delegates")]
        public DelegatesAssetCollection Delegates { get; set; }

        public override byte[] GetBytes()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    if (Delegates != null && Delegates.List != null)
                    {
                        foreach (var  del in Delegates.List)
                        {
                            writer.Write(del.FromHex());
                        }
                    }
                }
                return stream.ToArray();
            }
        }
    }
}
