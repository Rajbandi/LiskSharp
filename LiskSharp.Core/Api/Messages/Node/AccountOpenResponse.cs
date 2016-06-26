using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Api.Models;

namespace LiskSharp.Core.Api.Messages.Node
{
    /// <summary>
    /// Response class for handling output from Account open
    /// </summary>
    [DataContract]
    public class OpenAccountResponse : BaseResponse
    {
        [DataMember(Name = "account")]
        public Account Account { get; set; }
    }
}
