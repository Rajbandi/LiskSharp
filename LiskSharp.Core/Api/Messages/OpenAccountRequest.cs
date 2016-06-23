using System.Runtime.Serialization;

namespace LiskSharp.Core.Api.Messages
{
    [DataContract]
    public class OpenAccountRequest : BaseRequest
    {
        [DataMember(Name="secret")]
        public string Secret { get; set; }

        public override string ToQuery()
        {
            if (!string.IsNullOrWhiteSpace(Secret))
                QueryParams.Add($"secret={Secret}");

            return base.ToQuery();
        }
    }
}
