#region copyright
// <copyright file="TransactionRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages
{
    public class TransactionRequest : BaseRequest
    {
        [QueryParam(Name="id")]
        public string Id { get; set; }
    }
}
