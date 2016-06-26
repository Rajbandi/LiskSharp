using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class LoaderStatusSyncResponse : BaseResponse
    {
        [DataMember(Name = "syncing")]
        public bool Syncing { get; set; }

        [DataMember(Name = "blocks")]
        public int Blocks { get; set; }

        [DataMember(Name = "height")]
        public int Height { get; set; }
    }

}
