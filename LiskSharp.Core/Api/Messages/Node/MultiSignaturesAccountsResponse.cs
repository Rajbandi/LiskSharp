﻿#region copyright
// <copyright file="MultiSignaturesAccountsResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System.Collections.Generic;
using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Api.Models;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class MultiSignaturesAccountsResponse : BaseResponse
    {
        [DataMember(Name = "accounts")]
        public IList<Account> Accounts { get; set; }

    }
}
