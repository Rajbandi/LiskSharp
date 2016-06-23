#region copyright
// <copyright file="PeerRequest.cs" >
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
    
    public class PeerRequest : BaseRequest
    {
        
        public string Ip { get; set; }

        public string Port { get; set; }


        public override string ToQuery()
        {
          
            if (!string.IsNullOrWhiteSpace(Ip))
                QueryParams.Add(string.Format("ip={0}", Ip));

            if (!string.IsNullOrWhiteSpace(Port))
                QueryParams.Add(string.Format("port={0}", Port));

            return base.ToQuery();
        }
    }
}
