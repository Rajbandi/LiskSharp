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
