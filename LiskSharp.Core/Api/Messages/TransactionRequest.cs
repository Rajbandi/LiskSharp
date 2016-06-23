#region copyright
// <copyright file="TransactionRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

namespace LiskSharp.Core.Api.Messages
{
    public class TransactionRequest : BaseRequest
    {
        public string Id { get; set; }

        public override string ToQuery()
        {
            if(!string.IsNullOrWhiteSpace(Id))
                QueryParams.Add($"id={Id}");

            return base.ToQuery();
        }
    }
}
