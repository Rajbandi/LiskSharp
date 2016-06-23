#region copyright
// <copyright file="Address.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
using System.Text;
using NBitcoin.BouncyCastle.Math;

namespace LiskSharp.Core.Common
{
    public class Address
    {
        public Address()
        {
            KeyPair = new KeyPair();
        }
        public KeyPair KeyPair { get; set; }
        public BigInteger Id { get; set; }

        public string IdString
        {
            get { return string.Format("{0}L", Id ); }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Id String : {0}", IdString);
            stringBuilder.AppendLine();

            stringBuilder.AppendFormat("Id : {0}", Id);
            stringBuilder.AppendLine(KeyPair.ToString());
            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }
    }
}
