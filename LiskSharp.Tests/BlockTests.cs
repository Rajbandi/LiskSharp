using System;
using System.Diagnostics;
using LiskSharp.Core.Common;
using LiskSharp.Core.Helpers;
using NUnit.Framework;

namespace LiskSharp.Tests
{
    [TestFixture]
    public class BlockTests
    {
        private string _secret = "";
        private Account _genesisAccount;

        [TestFixtureSetUp]
        public void InitTests()
        {
            _secret = CryptoHelper.GenerateSecret();
            _genesisAccount = AccountHelper.GetAccount(_secret);
        }

        [Test]
        public void TestCreateNewBlock()
        {
            var dapp = new Dapp
            {
                Name = "Dapp1",
                Description = "Dapp1 Test",
                Git = "git@github.com:LiskHQ/LiskSDK.git",
                Category = 0,
                Type = 0,
                Link = "git@github.com:Rajbandi/DappTest.git"
            };

            var block = BlockHelper.CreateNewBlock(_genesisAccount, dapp);

			Debug.WriteLine(block);
        
        }
    }
}
