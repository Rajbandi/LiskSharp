#region copyright
// <copyright file="AccountDelegatesResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

using System.Collections.Generic;
using System.Runtime.Serialization;
using LiskSharp.Core.Api.Models;

namespace LiskSharp.Core.Api.Messages
{
    [DataContract]
    public class AccountDelegatesResponse : BaseResponse
    {
        [DataMember(Name = "delegates")]
        public IList<Delegate> Delegates { get; set; }
    }

}
