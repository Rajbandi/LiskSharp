#region copyright
// <copyright file="DelegateResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;
using Delegate = LiskSharp.Core.Api.Models.Delegate;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class DelegateResponse : BaseResponse
    {
        [DataMember(Name="delegate", Order = 2)]
        public Delegate Delegate { get; set; }
    }
}
