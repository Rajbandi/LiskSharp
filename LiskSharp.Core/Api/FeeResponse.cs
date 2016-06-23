#region copyright
// <copyright file="FeeResponse.cs" >
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
    public class FeeResponse : BaseResponse
    {
        [DataMember(Name = "fee")]
        public long Fee { get; set; }
    }

}
