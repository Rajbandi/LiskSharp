using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;

namespace LiskSharp.Core.Api.Messages.Peer
{
    [DataContract]
    public class PeerHeightResponse : BaseResponse
    {
        [DataMember(Name = "height")]
        public long? Height { get; set; }
    }
}
