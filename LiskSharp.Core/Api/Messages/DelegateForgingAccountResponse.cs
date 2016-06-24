﻿#region copyright
// <copyright file="DelegateForgingAccountResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

using System.Runtime.Serialization;

namespace LiskSharp.Core.Api.Messages
{
    [DataContract]
    public class DelegateForgingAccountResponse : BaseResponse
    {
        [DataMember(Name = "fees")]
        public string Fees { get; set; }

        [DataMember(Name = "rewards")]
        public string Rewards { get; set; }

        [DataMember(Name = "forged")]
        public string Forged { get; set; }
    }

}