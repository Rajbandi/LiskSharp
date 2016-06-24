using System.Diagnostics;
using LiskSharp.Core.Api;
using LiskSharp.Core.Api.Messages;
using LiskSharp.Core.Api.Models;
using NUnit.Framework;

namespace LiskSharp.Tests
{
    [TestFixture]
    public class LiskApiTests
    {
        LiskNodeApi _api;
        private Account _account;
        [TestFixtureSetUp]
        public void Init()
        {
            _api = new LiskNodeApi(new ApiInfo
            {
                UseHttps = true
            });
            /*
             * 
             * Lisk node requires account to be opened which creates new session prior using any account related api either 
             * through web interface or /api/accounts/open. Account tests always fail if no session created on the remote node.
             * The below code opens an account with a secret. The response returns account details.
             */

            var response =  _api.OpenAccount(new OpenAccountRequest
            {
                Secret = "cabbage chief join task universe hello grab slush page exit update brisk"
            });
            Debug.WriteLine("Account open {0}",response);
            Assert.IsTrue(response.Success, " Couldn't open account ");
            _account = response.Account;
        }

        #region Peer related tests

        [Test]
        [Category("Peer")]
        public async void GetPeersTest()
        {
            var response = await _api.GetPeersAsync();
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to peer test. Response={response}");
        }

        [Test]
        [Category("Peer")]
        public async void GetPeerTest()
        {
            var peer = await _api.GetPeerAsync(new PeerRequest
            {
                Ip = "104.251.218.222",
                Port = "8000"
            });
            Debug.WriteLine(peer);
            Assert.IsTrue(peer.Success, $"Unable to retrieve peer. Response={peer}");
        }

        [Test]
        [Category("Peer")]
        public async void GetVersion()
        {
            var version = await _api.GetVersionAsync();
            Debug.WriteLine(version);
            Assert.IsTrue(version.Success, $"Unable to retrieve version. Response={version}");
        }
        #endregion

        #region Delegates related tests

        [Test]
        [Category("Delegate")]
        public async void GetDelegates()
        {
            var response = await _api.GetDelegatesAsync();
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve delegates. Response={response}");
        }

        [Test]
        [Category("Delegate")]
        public async void GetDelegate()
        {
            var response = await _api.GetDelegateAsync(new DelegateRequest
            {
                Username = "genesis_97"
            });
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve delegate. Response={response}");
        }

        [Test]
        [Category("Delegate")]
        public async void GetDelegateFee()
        {
            var response = await _api.GetDelegateFeeAsync();
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve delegate fee. Response={response}");
        }

        [Test]
        [Category("Delegate")]
        public async void GetDelegateVoters()
        {
            var response = await _api.GetDelegateVotersAsync(new DelegateVotersRequest
            {
                PublicKey = "12b499298c5b15da545839aff50406f2a1ab0ee1ce66c31ff284e7d8e10a9b70"
            });
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success);
        }
        #endregion

        #region Signature related tests

        [Test]
        [Category("Signature")]
        public async void GetSignatureFee()
        {
            var response = await _api.GetSignatureFeeAsync();
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve signature fee. Response={response}");
        }

        #endregion

        #region Blocks related tests
        [Test]
        [Category("Block")]
        public async void GetBlocks()
        {

            var response = await _api.GetBlocksAsync(new BlocksRequest
            {

            });
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve blocks. Response={response}");
        }

        [Test]
        [Category("Block")]
        public async void GetBlock()
        {
            var response = await _api.GetBlockAsync(new BlockRequest
            {
                Id = "15583964572759425589"
            });
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve block. Response={response}");
        }

        [Test]
        [Category("Block")]
        public async void GetBlockFee()
        {
            var response = await _api.GetBlockFeeAsync();
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve block fee. Response={response}");
        }

        [Test]
        [Category("Block")]
        public async void GetBlockFees()
        {
            var response = await _api.GetBlockFeesAsync();
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve block fees. Response={response}");
        }

        [Test]
        [Category("Block")]
        public async void GetBlockReward()
        {
            var response = await _api.GetBlockRewardAsync();
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve block reward. Response={response}");
        }

        [Test]
        [Category("Block")]
        public async void GetBlockNethash()
        {
            var response = await _api.GetBlockNetHashAsync();
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve block net hash. Response={response}");
        }

        [Test]
        [Category("Block")]
        public async void GetBlockSupply()
        {
            var response = await _api.GetBlockSupplyAsync();
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve block supply. Response={response}");
        }

        [Test]
        [Category("Block")]
        public async void GetBlockStatus()
        {
            var response = await _api.GetBlockStatusAsync();
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve block status. Response={response}");
        }

        [Test]
        [Category("Block")]
        public async void GetBlockMilestone()
        {
            var response = await _api.GetBlockMilestoneAsync();
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve block milestone. Response={response}");
        }

        #endregion

        #region Accounts related tests

        [Test]
        [Category("Account")]
        public async void OpenAccount()
        {
            var response = await _api.OpenAccountAsync(new OpenAccountRequest
            {
                Secret= "cabbage chief join task universe hello grab slush page exit update brisk"
            });
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, "Unable to open account");
        }

        [Test]
        [Category("Account")]
        public async void GetAccount()
        {
            var response = await _api.GetAccountAsync(new AccountRequest
            {
                Address = _account.Address
            });
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve account details from the given address. Response={response}");
        }

        [Test]
        [Category("Account")]
        public async void GetAccountBalance()
        {
            var response = await _api.GetAccountBalanceAsync(new AccountRequest
            {
                Address = _account.Address
            });
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve account balance from the given address. Response={response}");
        }

        [Test]
        [Category("Account")]
        public async void GetAccountPublicKey()
        {
            var response = await _api.GetAccountPublickeyAsync(new AccountRequest
            {
                Address = _account.Address
            });
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve account public key from the given address. Response={response}");
        }

        [Test]
        [Category("Account")]
        public async void GetAccountDelegates()
        {
            var response = await _api.GetAccountDelegatesAsync(new AccountRequest
            {
                Address = _account.Address
            });
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve account delegates from the given address. Response={response}");
        }

        [Test]
        [Category("Account")]
        public async void GetAccountDelegatesFee()
        {
            var response = await _api.GetAccountDelegatesFeeAsync(new AccountRequest
            {
                Address = _account.Address
            });
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve account delegates fee from the given address. Response={response}");
        }
        
        #endregion

        #region Transaction related tests
        [Test]
        [Category("Transaction")]
        public async void GetTransactions()
        {
            var response = await _api.GetTransactionsAsync(new TransactionsRequest());
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve transactions. Response={response}");
        }

        [Test]
        [Category("Transaction")]
        public async void GetTransaction()
        {
            var response = await _api.GetTransactionAsync(new TransactionRequest
            {
                Id = "15748634892930294330"
            });
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve transaction. Response={response}");
        }

        [Test]
        [Category("Transaction")]
        public async void GetUnconfirmedTransactionsNoFilter()
        {
            var response = await _api.GetUnconfirmedTransactionsAsync(new UnconfirmedTransactionsRequest());
            Debug.WriteLine(response);
            Assert.IsTrue(response.Success, $"Unable to retrieve unconfirmed transactions. Response={response}");
        }
        /*
         * Disabling test due to uncertainity of unconfirmed transactions. Due to this, App veyor sometimes failing.
         * Enable if testing locally
        [Test]
        [Category("Transaction")]
        public async void GetUnconfirmedTransaction()
        {
            var transactions = await _api.GetUnconfirmedTransactionsAsync(new UnconfirmedTransactionsRequest());
            if (transactions != null && transactions.Success && transactions.Transactions != null &&
                transactions.Transactions.Count > 0)
            {

                var response = await _api.GetUnconfirmedTransactionAsync(new TransactionRequest
                {
                    Id = transactions.Transactions.First().Id
                });

                Debug.WriteLine(response);
                Assert.IsTrue(response.Success, $"Unable to retrieve unconfirmed transaction. Response={response}");
            }
            else
                Assert.Pass("No unconfirmed transactions found");
        }
        */

        #endregion
    }
}
