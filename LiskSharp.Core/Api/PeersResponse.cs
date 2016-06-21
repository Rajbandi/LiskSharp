using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LiskSharp.Core.Common;
using Newtonsoft.Json;

namespace LiskSharp.Core.Api
{
    [DataContract]
    public class PeersResponse : BaseResponse
    {
        [DataMember(Name = "peers", Order = 2)]
        public List<Peer> Peers = new List<Peer>();


     
    }
}
