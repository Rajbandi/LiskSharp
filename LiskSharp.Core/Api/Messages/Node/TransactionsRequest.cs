#region copyright
// <copyright file="TransactionsRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages.Node
{
    public class TransactionsRequest : BaseRequest
    {
        [QueryParam(Name="senderPublicKey")]
        public string SenderPublickey { get; set; }

        [QueryParam(Name="ownerPublicKey")]
        public string OwnerPublicKey { get; set; }

        [QueryParam(Name="ownerAddress")]
        public string OwnerAddress { get; set; }

        [QueryParam(Name="senderId")]
        public string SenderId { get; set; }

        [QueryParam(Name="recipientId")]
        public string RecipientId { get; set; }

        [QueryParam(Name="amount")]
        public long? Amount { get; set; }

        [QueryParam(Name="fee")]
        public int? Fee { get; set; }

        [QueryParam(Name="type")]
        public int? Type { get; set; }

        [QueryParam(Name="blockId")]
        public string BlockId { get; set; }
    }
}
