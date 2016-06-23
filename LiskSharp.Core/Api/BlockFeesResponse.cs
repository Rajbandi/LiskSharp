#region copyright
// <copyright file="BlockFeesResponse.cs" >
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
    public class BlockFeesResponse : BaseResponse
    {
        [DataMember(Name = "fees")]
        public Fees Fees { get; set; }
    }

}
