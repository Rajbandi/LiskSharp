#region copyright
// <copyright file="DelegateAddResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Api.Models;

namespace LiskSharp.Core.Api.Messages.Node
{
    /// <summary>
    /// Response for addDelegate
    /// </summary>
    [DataContract]
    public class DelegateAddResponse : BaseResponse
    {
        [DataMember(Name = "transaction")]
        public Transaction Transaction { get; set; }
    }
}
