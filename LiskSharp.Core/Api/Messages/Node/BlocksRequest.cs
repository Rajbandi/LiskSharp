#region copyright
// <copyright file="BlocksRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages.Node
{
    /// <summary>
    /// BlocksRequest used when retrieving more than one blocks
    /// /api/blocks
    /// </summary>
    public class BlocksRequest : BaseRequest
    {
        [QueryParam(Name= "generatorPublicKey")]
        public string GeneratorPublickey { get; set; }

        [QueryParam(Name = "totalAmount")]
        public long? TotalAmount { get; set; }

        [QueryParam(Name = "totalFee")]
        public int? TotalFee { get; set; }

        [QueryParam(Name = "reward")]
        public int? Reward { get; set; }

        [QueryParam(Name = "previousBlock")]
        public string PreviousBlock { get; set; }

        [QueryParam(Name = "height")]
        public int? Height { get; set; }
    }
}
