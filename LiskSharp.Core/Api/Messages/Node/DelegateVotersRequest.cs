#region copyright
// <copyright file="DelegateVotersRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages.Node
{
    public class DelegateVotersRequest : BaseRequest
    {
        [QueryParam(Name="publicKey")]
        public string PublicKey { get; set; }
    }
}
