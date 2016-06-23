﻿#region copyright
// <copyright file="BlockMilestoneResponse.cs" >
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
    public class BlockMilestoneResponse : BaseResponse
    {
        [DataMember(Name = "milestone")]
        public int Milestone { get; set; }
    }

}