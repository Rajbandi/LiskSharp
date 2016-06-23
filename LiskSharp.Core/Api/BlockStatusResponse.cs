#region copyright
// <copyright file="BlockStatusResponse.cs" >
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
    public class BlockStatusResponse : BaseResponse
    {
        [DataMember(Name = "height")]
        public int Height { get; set; }

        [DataMember(Name = "fee")]
        public int Fee { get; set; }

        [DataMember(Name = "milestone")]
        public int Milestone { get; set; }

        [DataMember(Name = "reward")]
        public int Reward { get; set; }

        [DataMember(Name = "supply")]
        public long Supply { get; set; }

    }
}
