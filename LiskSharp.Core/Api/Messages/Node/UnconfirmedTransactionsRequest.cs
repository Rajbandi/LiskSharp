#region copyright
// <copyright file="UnconfirmedTransactionsRequest.cs" >
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
    public class UnconfirmedTransactionsRequest : BaseRequest
    {
        [QueryParam(Name = "senderPublicKey")]
        public string SenderPublickey { get; set; }

        [QueryParam(Name = "address")]
        public string Address { get; set; }
    }
}
