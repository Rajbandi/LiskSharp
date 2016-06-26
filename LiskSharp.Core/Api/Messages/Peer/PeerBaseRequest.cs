using System.Net;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Attributes;
using LiskSharp.Core.Common;

namespace LiskSharp.Core.Api.Messages.Peer
{
    /// <summary>
    /// Base class for all the peer related api
    /// All the peer related api expects header values in the request
    /// </summary>
    public class PeerBaseRequest : BaseRequest
    {
        [HeaderValue(Name = "x-forwarded-for", Default = Constants.DefaultHost)]
        public string Host { get; set; }

        [HeaderValue(Name = "port", Default = Constants.DefaultPort)]
        public int? Port { get; set; }

        [HeaderValue(Name = "state", Default = Constants.DefaultState)]
        public int? State { get; set; }

        [HeaderValue(Name = "os", Default = Constants.DefaultOs)]
        public string Os { get; set; }

        [HeaderValue(Name = "version", Default = Constants.DefaultVersion)]
        public string Version { get; set; }

        [HeaderValue(Name = "nethash", Default = Constants.DefaultNethash)]
        public string Nethash { get; set; }
    }
}
