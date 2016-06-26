using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Api.Models;

namespace LiskSharp.Core.Api.Messages.Node
{
    /// <summary>
    /// Response class for delegates add 
    /// </summary>
    [DataContract]
    public class AccountDelegateAddResponse : BaseResponse
    {
        [DataMember(Name = "transaction")]
        public Transaction Transaction { get; set; }
    }
}
