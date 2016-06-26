using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages.Node
{
    /// <summary>
    /// Request class for /api/accounts/generatePublicKey
    /// </summary>
    public class AccountGeneratePublickeyRequest : BaseRequest
    {
        [QueryParam(Name = "secret")]
        public string Secret { get; set; }
    }
}
