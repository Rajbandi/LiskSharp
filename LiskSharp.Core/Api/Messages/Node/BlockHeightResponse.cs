#region copyright
// <copyright file="BlockHeightResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class BlockHeightResponse : BaseResponse
    {
        [DataMember(Name = "height")]
        public int Height { get; set; }
    }

}
