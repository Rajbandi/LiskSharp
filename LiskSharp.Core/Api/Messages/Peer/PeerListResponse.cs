using System.Collections.Generic;
using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;

namespace LiskSharp.Core.Api.Messages.Peer
{
    [DataContract]
    public class PeerListResponse : BaseResponse
    {
        [DataMember(Name = "peers")]
        public IList<Models.Peer> Peers { get; set; }
    }
}
