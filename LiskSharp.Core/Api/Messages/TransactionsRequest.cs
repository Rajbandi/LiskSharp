#region copyright
// <copyright file="TransactionsRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
namespace LiskSharp.Core.Api.Messages
{
    public class TransactionsRequest : BaseRequest
    {
        public string SenderPublickey { get; set; }

        public string OwnerPublicKey { get; set; }

        public string OwnerAddress { get; set; }

        public string SenderId { get; set; }

        public string RecipientId { get; set; }

        public long? Amount { get; set; }

        public int? Fee { get; set; }

        public int? Type { get; set; }

        public string BlockId { get; set; }

        public override string ToQuery()
        {
            if(!string.IsNullOrWhiteSpace(BlockId))
                QueryParams.Add($"blockId={BlockId}");

            if(!string.IsNullOrWhiteSpace(SenderPublickey))
                QueryParams.Add($"senderPublicKey={SenderPublickey}");

            if(!string.IsNullOrWhiteSpace(OwnerPublicKey))
                QueryParams.Add($"ownerPublicKey={OwnerPublicKey}");

            if(!string.IsNullOrWhiteSpace(OwnerAddress))
                QueryParams.Add($"ownerAddress={OwnerAddress}");

            if(!string.IsNullOrWhiteSpace(SenderId))
                QueryParams.Add($"senderId={SenderId}");

            if(!string.IsNullOrWhiteSpace(RecipientId))
                QueryParams.Add($"recipientId={RecipientId}");

            if(Amount.HasValue)
                QueryParams.Add($"amount={Amount}");

            if(Fee.HasValue)
                QueryParams.Add($"fee={Fee}");

            if(Type.HasValue)
                QueryParams.Add($"type={Type}");
            
            return base.ToQuery();
        }
    }
}
