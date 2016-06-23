#region copyright
// <copyright file="BaseResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LiskSharp.Core.Api
{
    [DataContract]
    public abstract class BaseResponse
    {
        [DataMember(Name="success", Order = 1)]
        public bool Success { get; set; }

        [DataMember(Name = "error", Order = 2,EmitDefaultValue = false, IsRequired = false)]
        public string Error { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
