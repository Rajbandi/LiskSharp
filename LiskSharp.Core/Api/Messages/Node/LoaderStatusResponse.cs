using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class LoaderStatusResponse : BaseResponse
    {
        [DataMember(Name = "loaded")]
        public bool Loaded { get; set; }

        [DataMember(Name = "blocksCount")]
        public int BlocksCount { get; set; }
    }
}
