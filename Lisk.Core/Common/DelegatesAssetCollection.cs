using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Common
{
    [DataContract]
    public class DelegatesAssetCollection
    {
        public DelegatesAssetCollection()
        {
            
        }

        public DelegatesAssetCollection(IEnumerable<string> delegates)
        {
            List.AddRange(delegates);
        }

        [DataMember(Name = "list")]
        public List<string> List = new List<string>(); 
    }
}
