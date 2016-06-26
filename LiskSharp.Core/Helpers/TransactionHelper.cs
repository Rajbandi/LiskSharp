#region copyright
// <copyright file="TransactionHelper.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskSharp.Core.Extensions;
using NBitcoin;
using Transaction = LiskSharp.Core.Common.Transaction;

namespace LiskSharp.Core.Helpers
{
    public static class TransactionHelper
    {
        public static byte[] GetBytes(Transaction trs, bool skipSignature = true, bool skipSecondSignature = true)
        {
            using (var ms = new MemoryStream())
            {
                if (trs != null)
                {
                    using (var br = new BinaryWriter(ms))
                    {
                        br.Write((short)trs.Type);
                        br.Write(trs.Timestamp);
                        br.Write(trs.SenderPublicKey.FromHex());
                        br.Write(trs.RequesterPublicKey.FromHex());
                        if (!string.IsNullOrWhiteSpace(trs.RecipientId))
                        {
                            
                        }

                        br.Write(trs.Amount);
                        
                    }
                }
                return ms.ToArray();
            }
        }
    }
}
