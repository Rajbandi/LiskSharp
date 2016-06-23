#region copyright
// <copyright file="AccountRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
namespace LiskSharp.Core.Api.Messages
{
    public class AccountRequest : BaseRequest
    {
        public string Address { get; set; }

        public override string ToQuery()
        {
            if (!string.IsNullOrWhiteSpace(Address))
            {
                QueryParams.Add($"address={Address}");
            }
            return base.ToQuery();
        }
    }
}
