using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;

namespace LiskSharp.Core.Api.Messages.Node
{
    /// <summary>
    /// Response class for addTransaction
    /// </summary>
    [DataContract]
    public class TransactionAddResponse : BaseResponse
    {
        [DataMember(Name = "transactionId")]
        public string TransactionId { get; set; }
    }
}
