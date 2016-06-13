using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Common
{
    [DataContract]
    public class DelegateUsername
    {
        [DataMember(Name = "username")]
        public string Username { get; set; }
    }
}
