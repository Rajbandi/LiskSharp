using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class MultiSignaturesAddResponse : BaseResponse
    {
        [DataMember(Name = "transactionId")]
        public string TransactionId { get; set; }
    }
}
