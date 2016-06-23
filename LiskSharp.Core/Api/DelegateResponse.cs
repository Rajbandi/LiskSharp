#region copyright
// <copyright file="DelegateResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Api
{
    [DataContract]
    public class DelegateResponse : BaseResponse
    {
        [DataMember(Name="delegate", Order = 2)]
        public Delegate Delegate { get; set; }
    }
}
