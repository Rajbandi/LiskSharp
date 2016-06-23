#region copyright
// <copyright file="DelegateRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

namespace LiskSharp.Core.Api.Messages
{
    /// <summary>
    /// Delegate request 
    /// </summary>
    public class DelegateRequest : BaseRequest
    {
        public string TransactionId { get; set; }

        public string Username { get; set; }

        public string PublicKey { get; set; }

        public override string ToQuery()
        {
            if (!string.IsNullOrWhiteSpace(TransactionId))
                QueryParams.Add($"transactionid={TransactionId}");

            if (!string.IsNullOrWhiteSpace(PublicKey))
                QueryParams.Add($"publicKey={PublicKey}");

            if (!string.IsNullOrWhiteSpace(Username))
                QueryParams.Add($"username={Username}");

            return base.ToQuery();
        }
    }
}
