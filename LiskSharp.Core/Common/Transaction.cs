#region copyright
// <copyright file="Transaction.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LiskSharp.Core.Extensions;
using NBitcoin.BouncyCastle.Math;
using Newtonsoft.Json;

namespace LiskSharp.Core.Common
{
    [DataContract]
    public class Transaction
    {
        public BigInteger Id { get; set; }

        [DataMember(Name = "type")]
        public TransactionType Type { get; set; }

        [DataMember(Name = "amount")]
        public long Amount { get; set; }

        [DataMember(Name = "fee")]
        public int Fee { get; set; }

        [DataMember(Name = "timestamp")]
        public int Timestamp { get; set; }

        [DataMember(Name = "recipientid")]
        public string RecipientId { get; set; }

        [DataMember(Name = "senderid")]
        public string SenderId { get; set; }

        [DataMember(Name = "senderPublicKey")]
        public string SenderPublicKey { get; set; }

        [DataMember(Name = "requesterPublicKey")]
        public string RequesterPublicKey { get; set; }

        [DataMember(Name = "asset")]
        public Asset Asset { get; set; }

        [DataMember(Name = "signature")]
        public string Signature { get; set; }

        public override string ToString()
        {
            var json = JsonConvert.SerializeObject(this);
            return json;
        }
        public byte[] GetBytes(bool skipSignature = false)
        {
            int assetSize = 0;
            
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write((byte)Type);
                    writer.Write(Timestamp);
                    writer.Write(SenderPublicKey.FromHex());
                    if (RecipientId != null)
                    {
                        var recId = new BigInteger(RecipientId.Replace("L", ""));
                        writer.Write(recId.ToByteArray());
                    }
                    else
                    {
                        writer.Write(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
                    }
                    writer.Write(Amount);
                    if (Asset != null)
                    {
                        writer.Write(Asset.GetBytes());
                    }
                    if (!skipSignature && !string.IsNullOrWhiteSpace(Signature))
                    {
                        writer.Write(Signature.FromHex());
                    }
                }
                return stream.ToArray();
            }
        }
    }
}
