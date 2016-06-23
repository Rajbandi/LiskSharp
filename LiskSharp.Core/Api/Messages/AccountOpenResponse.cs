using System.Runtime.Serialization;
using LiskSharp.Core.Api.Models;

namespace LiskSharp.Core.Api.Messages
{
    [DataContract]
    public class OpenAccountResponse : BaseResponse
    {
        [DataMember(Name = "account")]
        public Account Account { get; set; }
    }
}
