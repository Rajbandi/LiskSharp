using System;
using System.Collections.Generic;
using System.Linq;
using LiskSharp.Core.Common;
using LiskSharp.Core.Extensions;
using LiskSharp.Core.Helpers;
using NUnit.Framework;

namespace LiskSharp.Tests
{
    [TestFixture]
    public class TransactionTests
    {
        private string _secret = "";
        private string _senderSecret = "";
        private Account _genesisAccount, _sender;
        private List<Account> _delegates = new List<Account>();

        [TestFixtureSetUp]
        public void InitTests()
        {
            _secret = CryptoHelper.GenerateSecret();
            
            _genesisAccount = AccountHelper.GetAccount(_secret);

            _senderSecret = CryptoHelper.GenerateSecret();
            
            _sender = AccountHelper.GetAccount(_senderSecret);

            for (int index = 0; index < 10; index++)
            {
                var secret = CryptoHelper.GenerateSecret();
                _delegates.Add(AccountHelper.GetAccount(secret));
            }

        }
        [Test]
        public void TestBalanceTransaction()
        {
            var balTransaction = new Transaction
            {
                Type = TransactionType.Send,
                Amount = 10000000000000000,
                Fee = 0,
                Timestamp = 0,
                RecipientId = _genesisAccount.Address.IdString,
                SenderId = _sender.Address.IdString,
                SenderPublicKey = _sender.Address.KeyPair.PublicKey.ToHex(),
            };

        }

        [Test]
        public void TestDelegateTransaction()
        {
            var userName = "genesisAccount1";

            var delTransaction = new Transaction
            {
                Type = TransactionType.Delegate,
                Amount = 0,
                Fee = 0,
                Timestamp = 0,
                RecipientId = null,
                SenderId = _sender.Address.IdString,
                SenderPublicKey = _sender.Address.KeyPair.PublicKey.ToHex(),

                Asset = new DelegateUsernameAsset
                {
                    Delegate = new DelegateUsername
                    {
                        Username = userName
                    }
                }
            };

        }

        [Test]
        public void TestMultiDelegatesTransaction()
        {
            
            var delTransaction = new Transaction
            {
                Type = TransactionType.Multi,
                Amount = 0,
                Fee = 0,
                Timestamp = 0,
                RecipientId = null,
                SenderId = _sender.Address.IdString,
                SenderPublicKey = _sender.Address.KeyPair.PublicKey.ToHex(),

                Asset = new DelegatesAsset()
                {
                    Delegates = new DelegatesAssetCollection
                    {
                        List = _delegates.Select(x=> string.Format("+{0}", x.Address.KeyPair.PublicKey.ToHex())).ToList()
                    }
                }
            };

        }
    }
}
