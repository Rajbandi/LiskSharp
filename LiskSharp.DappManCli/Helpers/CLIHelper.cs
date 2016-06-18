using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskSharp.Core.Common;
using LiskSharp.Core.Exceptions;
using LiskSharp.Core.Helpers;

namespace LiskSharp.DappManCli.Helpers
{
    public static class CliHelper
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
                result.Error = "An error occurred " + ex.Message;
            }

            return result;
        }


    }
}
