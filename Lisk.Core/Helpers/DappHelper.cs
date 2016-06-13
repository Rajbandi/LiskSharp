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
        public static DappResult CreateDapp(DappConfig config)
        {
            var result = new DappResult();

            try
            {
                if (string.IsNullOrWhiteSpace(config.Name))
                {
                    throw new DappException("Dapp Name is required");
                }

                if (string.IsNullOrWhiteSpace(config.Description))
                {
                    throw new DappException("Dapp Description is required");
                }

                if (string.IsNullOrWhiteSpace(config.Secret))
                {
                    throw new DappException("Dapp Secret is required");
                }

                if (string.IsNullOrWhiteSpace(config.PublicKeys))
                {
                    throw new DappException("Dapp Public Keys is required");
                }
                if (string.IsNullOrWhiteSpace(config.SdkLink))
                {
                    throw new DappException("Sdk link is invalid");
                }

                if (config.IsGit)
                {
                    if (string.IsNullOrWhiteSpace(config.GitUsername) || string.IsNullOrWhiteSpace(config.GitPassword))
                    {
                        throw new DappException("IsGit checked, Git user credentials are required");
                    }
                    if (string.IsNullOrWhiteSpace(config.Git))
                    {
                        throw new DappException("Git link invalid");
                    }
                }

                var genesisAccount = AccountHelper.GetAccount(config.Secret);
                Block block;
                if (config.NewGenesisBlock)
                {
                    block = BlockHelper.CreateNewBlock(genesisAccount, config.ToDapp());
                }
                else
                {
                    //block = BlockHelper.CreateFromBlock()
                }

            }
            catch (DappException ex)
            {
                result.Error = ex.Message;
            }
            catch (Exception ex)
            {
                result.Error = "An error occurred "+ex.Message;
            }

            return result;
        }

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
