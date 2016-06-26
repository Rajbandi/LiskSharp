using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class OpenAccountRequest : BaseRequest
    {
        [DataMember(Name="secret")]
        [QueryParam(Name="secret")]
        public string Secret { get; set; }
    }
}
