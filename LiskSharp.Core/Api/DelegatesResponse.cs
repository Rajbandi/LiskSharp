﻿#region copyright
// <copyright file="DelegatesResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LiskSharp.Core.Api
{
    [DataContract]
    public class DelegatesResponse : BaseResponse
    {
        [DataMember(Name = "delegates", Order = 2)]
        public List<Delegate> Delegates { get; set; }

        [DataMember(Name = "totalcount", Order = 3)]
        public int TotalCount { get; set; }
    }
}
