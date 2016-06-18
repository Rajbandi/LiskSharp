using System;
using System.Linq;
using LiskSharp.Core.Common;
using LiskSharp.Core.Exceptions;
using LiskSharp.Core.Extensions;
using NBitcoin.BouncyCastle.Math;

namespace LiskSharp.Core.Helpers
{
    public static class DappHelper
    {
       
        public static GenesisBlock CreateBlock(Account genesisAccount, Block genesisBlock, string[] publicKeys)
        {
            var keys = publicKeys.Select(x => string.Format("+{0}", x)).ToList();
            var delegateTransaction = new Transaction
            {
                Type = TransactionType.Multi,
                Amount = 0,
                Fee = 0,
                Timestamp = 0,
                RecipientId = null,
                SenderId = genesisAccount.Address.IdString,
                SenderPublicKey = genesisAccount.Address.KeyPair.PublicKey.ToHex(),
                Asset = new DelegatesAsset
                {
                    Delegates = new DelegatesAssetCollection(keys)
                }
            };

            var block = new GenesisBlock
            {
                PointId = new BigInteger(genesisBlock.Id),
                PointHeight = 1,
                Height = 1,
                Delegate = genesisAccount.Address.KeyPair.PublicKey.ToHex(),
                Timestamp = 0
            };

            block.Transactions.Add(delegateTransaction);
            block.Count = block.Transactions.Count;

            var bytes = delegateTransaction.GetBytes();
            delegateTransaction.Signature = CryptoHelper.Sign(bytes, genesisAccount.Address.KeyPair.PrivateKey).ToHex();
            //bytes = delegateTransaction.GetBytes();
            delegateTransaction.Id = CryptoHelper.GetId(bytes);

            block.PayloadLength = bytes.Length;
            block.PayloadHash = CryptoHelper.Sha256(bytes).ToHex();

            var blockBytes = block.GetBytes();
            block.Signature = CryptoHelper.Sign(blockBytes, genesisAccount.Address.KeyPair.PrivateKey).ToHex();
            block.Id = CryptoHelper.GetId(bytes);

            return block;
        }
    }
}
