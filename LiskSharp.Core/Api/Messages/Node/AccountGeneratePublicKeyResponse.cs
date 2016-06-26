using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;

namespace LiskSharp.Core.Api.Messages.Node
{
    /// <summary>
    /// Response object for account generate public key
    /// </summary>
    [DataContract]
    public class AccountGeneratePublicKeyResponse : BaseResponse
    {
        [DataMember(Name = "publicKey", EmitDefaultValue = false)]
        public string PublicKey { get; set; }
    }
}
