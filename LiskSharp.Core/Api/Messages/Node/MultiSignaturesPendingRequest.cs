using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages.Node
{
    public class MultiSignaturesPendingRequest : BaseRequest
    {
        [QueryParam(Name="publicKey")]
        public string PublicKey { get; set; }
    }
}
