﻿#region copyright
// <copyright file="TransactionsResponse.cs" >
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
    public class TransactionsResponse : BaseResponse
    {
        [DataMember(Name = "transactions")]
        public IList<Transaction> Transactions { get; set; }

        [DataMember(Name = "count")]
        public string Count { get; set; }
    }

}
