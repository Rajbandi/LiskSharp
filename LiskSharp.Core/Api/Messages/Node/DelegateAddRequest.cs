using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class DelegateAddRequest : BaseRequest
    {
        [DataMember(Name = "secret")]
        public string Secret { get; set; }

        [DataMember(Name = "secondSecret")]
        public string SecondSecret { get; set; }

        [DataMember(Name = "publicKey")]
        public string PublicKey { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }
    }
}
