using System;
using LiskSharp.Core.Helpers;
using NUnit.Framework;
using System.Diagnostics;

namespace LiskSharp.Tests
{
   
    public class AccountTests
    {
    
        [Test]
        public void TestSecret()
        {
			
            var code = CryptoHelper.GenerateSecret();
            Debug.WriteLine(code);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(code), "Invalid Mneumonic code");
            Assert.IsTrue(code.Split(" ".ToCharArray()).Length == 12, "BIP39 Mneumonic code must contain 12 words.");
        }

        [Test]
        public void TestAddress()
        {
            var secret = "artefact road payment cloud dinosaur twelve soon acquire ask tennis dash topic";
            Debug.WriteLine(secret);
            var address = CryptoHelper.GetAddress(secret);
            Debug.WriteLine(address);
            Assert.IsTrue(address.IdString == "14254208205927701393L");
        }

    }
}
