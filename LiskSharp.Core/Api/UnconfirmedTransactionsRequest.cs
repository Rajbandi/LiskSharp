#region copyright
// <copyright file="UnconfirmedTransactionsRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
namespace LiskSharp.Core.Api
{
    public class UnconfirmedTransactionsRequest : BaseRequest
    {
        public string SenderPublickey { get; set; }

        public string Address { get; set; }

        public override string ToQuery()
        {
            if(!string.IsNullOrWhiteSpace(SenderPublickey))
                QueryParams.Add($"senderPublicKey={SenderPublickey}");

            if(!string.IsNullOrWhiteSpace(Address))
                QueryParams.Add($"address={Address}");

            return base.ToQuery();
        }
    }
}
