using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Api
{
    /// <summary>
    /// Peer version response
    /// </summary>
    [DataContract]
    public class VersionResponse : BaseResponse
    {
        [DataMember(Name = "version", Order=2)]
        public string Version { get; set; }

        [DataMember(Name = "build", Order = 3)]
        public string Build { get; set; }
    }
}
