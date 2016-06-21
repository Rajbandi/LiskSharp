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
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public virtual string ToQuery()
        {
            return string.Empty;
        }
    }
}
