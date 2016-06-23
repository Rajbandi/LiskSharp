#region copyright
// <copyright file="DelegateForgingAccountRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
namespace LiskSharp.Core.Api
{
    public class DelegateForgingAccountRequest : BaseRequest
    {
        public string GeneratorPublickey { get; set; }

        public override string ToQuery()
        {
            QueryParams.Add($"generatorPublicKey={GeneratorPublickey}");
            return base.ToQuery();
        }
    }
}
