using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages.Node
{
    public class MultiSignaturesSignRequest : BaseRequest
    {
        [QueryParam(Name = "secret")]
        public string Secret { get; set; }

        [QueryParam(Name = "secondSecret")]
        public string SecondSecret { get; set; }

        [QueryParam(Name="publicKey")]
        public string PublicKey { get; set; }

        [QueryParam(Name = "transactionId")]
        public string TransactionId { get; set; }
    }
}
