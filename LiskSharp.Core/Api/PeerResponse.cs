using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LiskSharp.Core.Common;

namespace LiskSharp.Core.Api
{
    [DataContract]
    public class PeerResponse : BaseResponse
    {
        [DataMember(Name = "peer", Order = 2)]
        public Peer Peer { get; set; }
    }
}
