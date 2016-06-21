using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LiskSharp.Core.Api
{
    [DataContract]
    public class DelegatesResponse : BaseResponse
    {
        [DataMember(Name = "delegates", Order = 2)]
        public List<Delegate> Delegates { get; set; }

        [DataMember(Name = "totalcount", Order = 3)]
        public int TotalCount { get; set; }
    }
}
