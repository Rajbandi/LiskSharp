#region copyright
// <copyright file="BaseRequest.cs" >
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
using Newtonsoft.Json;

namespace LiskSharp.Core.Api
{
    public abstract class BaseRequest
    {
        protected readonly List<string> QueryParams = new List<string>();

        public int? Limit { get; set; } 
        public int? Offset { get; set; }
        public string OrderBy { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public virtual string ToQuery()
        {
            if (Limit.HasValue)
            {
                QueryParams.Add($"limit={Limit}");
            }
            if (Offset.HasValue)
            {
                QueryParams.Add($"offset={Offset}");
            }

            if (!string.IsNullOrWhiteSpace(OrderBy))
            {
                QueryParams.Add($"orderBy={OrderBy}");
            }
            return string.Join("&", QueryParams.ToArray());
        }
    }
}
