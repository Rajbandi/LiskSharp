﻿#region copyright
// <copyright file="AccountBalanceResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
using System.Runtime.Serialization;

namespace LiskSharp.Core.Api
{
    [DataContract]
    public class AccountBalanceResponse : BaseResponse
    {
        [DataMember(Name = "balance")]
        public long Balance { get; set; }

        [DataMember(Name = "unconfirmedBalance")]
        public long UnconfirmedBalance { get; set; }
    }
}
