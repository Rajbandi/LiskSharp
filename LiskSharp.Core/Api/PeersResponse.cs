#region copyright
// <copyright file="PeersResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
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
