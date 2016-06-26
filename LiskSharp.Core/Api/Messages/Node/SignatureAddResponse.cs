using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Api.Models;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class SignatureAddResponse : BaseResponse
    {
        [DataMember(Name = "transaction")]
        public Transaction Transaction { get; set; }
    }
}
