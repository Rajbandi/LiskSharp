#region copyright
// <copyright file="PeerRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages.Node
{
    public class PeerRequest : BaseRequest
    {
        [QueryParam(Name="ip")]
        public string Ip { get; set; }

        [QueryParam(Name="port")]
        public string Port { get; set; }
    }
}
