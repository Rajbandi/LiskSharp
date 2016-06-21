using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Api
{
    /// <summary>
    /// Delegate request 
    /// </summary>
    [DataContract]
    public class DelegateRequest : BaseRequest
    {
        [DataMember(Name = "transactionid")]
        public string TransactionId { get; set; }

        [DataMember(Name = "publickey")]
        public string PublicKey { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        public override string ToQuery()
        {
            var query = new List<string>();
            if (!string.IsNullOrWhiteSpace(TransactionId))
                query.Add(string.Format("transactionid={0}", TransactionId));

            if (!string.IsNullOrWhiteSpace(PublicKey))
                query.Add(string.Format("publickey={0}", PublicKey));

            if (!string.IsNullOrWhiteSpace(Username))
                query.Add(string.Format("username={0}", Username));

            return string.Join("&", query.ToArray());
        }
    }
}
