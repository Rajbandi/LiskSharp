using System.Collections.Generic;
using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Api.Models;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class MultiSignaturesPendingResponse : BaseResponse
    {
        [DataMember(Name = "transactions")]
        public IList<Transaction> Transactions { get; set; }

    }
}
