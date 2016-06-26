using System.Collections.Generic;
using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Api.Models;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class MultiSignaturesAccountsResponse : BaseResponse
    {
        [DataMember(Name = "accounts")]
        public IList<Account> Accounts { get; set; }

    }
}
