#region copyright
// <copyright file="AccountRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

using System.Security.Principal;
using System.Xml;
using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages
{
    public class AccountRequest : BaseRequest
    {
        [QueryParam(Name = "address")]
        public string Address { get; set; }
    }
}
