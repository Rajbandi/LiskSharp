#region copyright
// <copyright file="ILiskNodeApi.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
using System.Threading.Tasks;
using LiskSharp.Core.Api.Messages;

namespace LiskSharp.Core.Api
{
    public interface ILiskNodeApi
    {
        /// <summary>
        /// Get all delegates from a node synchronously 
        /// </summary>
        /// <returns>DelegatesResponse with delegates</returns>
        DelegatesResponse GetDelegates();

        /// <summary>
        /// Get all delegates from a node asynchronously 
        /// </summary>
        /// <returns>DelegatesResponse with delegates</returns>
        Task<DelegatesResponse> GetDelegatesAsync();

        /// <summary>
        /// Get a delegate from given parameters synchronously 
        /// </summary>
        /// <returns>DelegatesResponse with delegates</returns>
        DelegateResponse GetDelegate(DelegateRequest req);

        /// <summary>
        /// Get a delegate from given parameters asynchronously 
        /// </summary>
        /// <returns>DelegatesResponse with delegates</returns>
        Task<DelegateResponse> GetDelegateAsync(DelegateRequest req);

        /// <summary>
        /// Get all delegate fee from a node synchronously 
        /// </summary>
        /// <returns>DelegatesFeeResponse with fee</returns>
        FeeResponse GetDelegateFee();

        /// <summary>
        /// Get all delegate fee from a node asynchronously 
        /// </summary>
        /// <returns>DelegatesFeeResponse with fee</returns>
        Task<FeeResponse> GetDelegateFeeAsync();

        /// <summary>
        /// Get all delegate votes from a public key synchronously 
        /// </summary>
        /// <returns>DelegateVotersResponse with voters</returns>
        DelegateVotersResponse GetDelegateVoters(DelegateVotersRequest req);

        /// <summary>
        /// Get all delegate votes from a public key asynchronously 
        /// </summary>
        /// <returns>DelegateVotersResponse with voters</returns>
        Task<DelegateVotersResponse> GetDelegateVotersAsync(DelegateVotersRequest req);

        /// <summary>
        /// Get all delegate forging account from a public key synchronously 
        /// </summary>
        /// <returns>DelegateForgingAccountResponse with account details</returns>
        DelegateForgingAccountResponse GetDelegateForgingAccount(DelegateForgingAccountRequest req);

        /// <summary>
        /// Get all delegate forging account from a public key asynchronously 
        /// </summary>
        /// <returns>DelegateForgingAccountResponse with account details</returns>
        Task<DelegateForgingAccountResponse> GetDelegateForgingAccountAsync(DelegateForgingAccountRequest req);

        /// <summary>
        /// Get all peers from a node synchronously 
        /// </summary>
        /// <returns>Peers response with peer list</returns>
        PeersResponse GetPeers();

        /// <summary>
        /// Get all peers from a node asynchronously 
        /// </summary>
        /// <returns>Peers response with peer list</returns>
        Task<PeersResponse> GetPeersAsync();

        /// <summary>
        /// Get single peer related information from node synchronously
        /// </summary>
        /// <returns></returns>
        PeerResponse GetPeer(PeerRequest peer);

        /// <summary>
        /// Get single peer related information from node asynchronously
        /// </summary>
        /// <returns></returns>
        Task<PeerResponse> GetPeerAsync(PeerRequest peer);

        /// <summary>
        /// Get single peer related information from node synchronously
        /// </summary>
        /// <returns></returns>
        VersionResponse GetVersion();

        /// <summary>
        /// Get single peer related information from node asynchronously
        /// </summary>
        /// <returns></returns>
        Task<VersionResponse> GetVersionAsync();

        /// <summary>
        /// Gets list of block synchronously  
        /// </summary>
        /// <param name="req">BlocksRequest</param>
        /// <returns>BlocksResponse with blocks list</returns>
        BlocksResponse GetBlocks(BlocksRequest req);

        /// <summary>
        /// Gets list of blocks asynchronously 
        /// </summary>
        /// <param name="req">BlocksRequest</param>
        /// <returns>BlocksResponse with blocks list</returns>
        Task<BlocksResponse> GetBlocksAsync(BlocksRequest req);

        /// <summary>
        /// Gets a block by id synchronously
        /// path: /api/blocks/get
        /// </summary>
        /// <param name="req">BlockRequest</param>
        /// <returns>BlockResponse with block details</returns>
        BlockResponse GetBlock(BlockRequest req);

        /// <summary>
        /// Gets a block by id
        /// path: /api/blocks/get
        /// </summary>
        /// <param name="req">BlockRequest</param>
        /// <returns>BlockResponse with block details</returns>
        Task<BlockResponse> GetBlockAsync(BlockRequest req);

        /// <summary>
        /// Gets the block fee synchronously
        /// </summary>
        /// <returns>BlocksFeeResponse with fee details</returns>
        FeeResponse GetBlockFee();

        /// <summary>
        /// Gets the block fee asynchronously
        /// </summary>
        /// <returns>BlocksFeeResponse with fee details</returns>
        Task<FeeResponse> GetBlockFeeAsync();

        /// <summary>
        /// Gets blocks fee synchronously
        /// </summary>
        /// <returns>BlocksFeesResponse with fees details</returns>
        BlockFeesResponse GetBlockFees();

        /// <summary>
        /// Gets blocks fee asynchronously
        /// </summary>
        /// <returns>BlocksFeesResponse with fees details</returns>
        Task<BlockFeesResponse> GetBlockFeesAsync();

        /// <summary>
        /// Gets block height synchronously
        /// </summary>
        /// <returns>BlocksHeightResponse with height details</returns>
        BlockHeightResponse GetBlockHeight();

        /// <summary>
        /// Gets block height asynchronously
        /// </summary>
        /// <returns>BlocksHeightResponse with height details</returns>
        Task<BlockHeightResponse> GetBlockHeightAsync();

        /// <summary>
        /// Gets blocks net hash synchronously
        /// </summary>
        /// <returns>BlocksNethashResponse with net hash details</returns>
        BlockNethashResponse GetBlockNetHash();

        /// <summary>
        /// Gets blocks net hash asynchronously
        /// </summary>
        /// <returns>BlocksNethashResponse with net hash details</returns>
        Task<BlockNethashResponse> GetBlockNetHashAsync();

        /// <summary>
        /// Gets blocks milestone synchronously
        /// </summary>
        /// <returns>BlocksMilestoneResponse with milestone details</returns>
        BlockMilestoneResponse GetBlockMilestone();

        /// <summary>
        /// Gets blocks milestone asynchronously
        /// </summary>
        /// <returns>BlocksMilestoneResponse with milestone details</returns>
        Task<BlockMilestoneResponse> GetBlockMilestoneAsync();

        /// <summary>
        /// Gets blocks reward synchronously
        /// </summary>
        /// <returns>BlocksRewardResponse with reward details</returns>
        BlockRewardResponse GetBlockReward();

        /// <summary>
        /// Gets blocks reward asynchronously
        /// </summary>
        /// <returns>BlocksRewardResponse with reward details</returns>
        Task<BlockRewardResponse> GetBlockRewardAsync();

        /// <summary>
        /// Gets blocks supply asynchronously
        /// </summary>
        /// <returns>BlocksSupplyResponse with supply details</returns>
        BlockSupplyResponse GetBlockSupply();

        /// <summary>
        /// Gets blocks supply asynchronously
        /// </summary>
        /// <returns>BlocksSupplyResponse with supply details</returns>
        Task<BlockSupplyResponse> GetBlockSupplyAsync();

        /// <summary>
        /// Gets blocks status synchronously
        /// </summary>
        /// <returns>BlocksStatusResponse with status</returns>
        BlockStatusResponse GetBlockStatus();

        /// <summary>
        /// Gets blocks status asynchronously
        /// </summary>
        /// <returns>BlocksStatusResponse with status</returns>
        Task<BlockStatusResponse> GetBlockStatusAsync();

        /// <summary>
        /// Gets signature fee asynchronously
        /// </summary>
        /// <returns>FeeResponse with fee details</returns>
        FeeResponse GetSignatureFee();

        /// <summary>
        /// Gets signature fee asynchronously
        /// </summary>
        /// <returns>FeeResponse with fee details</returns>
        Task<FeeResponse> GetSignatureFeeAsync();

        /// <summary>
        /// Gets a transaction by a given id synchronously
        /// </summary>
        /// <returns>TransactionResponse with transaction details</returns>
        TransactionResponse GetTransaction(TransactionRequest req);

        /// <summary>
        /// Gets a transaction by a given id asynchronously
        /// </summary>
        /// <returns>TransactionResponse with transaction details</returns>
        Task<TransactionResponse> GetTransactionAsync(TransactionRequest req);

        /// <summary>
        /// Gets all the transactions synchronously
        /// </summary>
        /// <returns>TransactionsResponse with transactions list</returns>
        TransactionsResponse GetTransactions(TransactionsRequest req);

        /// <summary>
        /// Gets all the transactions asynchronously
        /// </summary>
        /// <returns>TransactionsResponse with transactions list</returns>
        Task<TransactionsResponse> GetTransactionsAsync(TransactionsRequest req);

        /// <summary>
        /// Gets all the unconfirmed transactions synchronously
        /// </summary>
        /// <returns>TransactionResponse with transactions list</returns>
        TransactionsResponse GetUnconfirmedTransactions(UnconfirmedTransactionsRequest req);

        /// <summary>
        /// Gets all the unconfirmed transactions asynchronously
        /// </summary>
        /// <returns>TransactionResponse with unconfirmed transactions list</returns>
        Task<TransactionsResponse> GetUnconfirmedTransactionsAsync(UnconfirmedTransactionsRequest req);

        /// <summary>
        /// Gets a unconfirmed transaction by a given id synchronously
        /// </summary>
        /// <returns>TransactionResponse with unconfirmed transaction details</returns>
        TransactionResponse GetUnconfirmedTransaction(TransactionRequest req);

        /// <summary>
        /// Gets a unconfirmed transaction by a given id asynchronously
        /// </summary>
        /// <returns>TransactionResponse with unconfirmed transaction details</returns>
        Task<TransactionResponse> GetUnconfirmedTransactionAsync(TransactionRequest req);

        /// <summary>
        /// Gets account details from a given address synchronously
        /// Only applicable when account session is already opened with /account/open
        /// Otherwise return null.
        /// </summary>
        /// <returns>AccountResponse with account details</returns>
        AccountResponse GetAccount(AccountRequest acc);

        /// <summary>
        /// Gets account details from a given address asynchronously
        /// Only applicable when account session is already opened with /account/open
        /// Otherwise return null.
        /// </summary>
        /// <returns>AccountResponse with account details</returns>
        Task<AccountResponse> GetAccountAsync(AccountRequest acc);

        /// <summary>
        /// Gets account balance from a given address synchronously
        /// </summary>
        /// <returns>AccountBalanceResponse with balance</returns>
        AccountBalanceResponse GetAccountBalance(AccountRequest acc);

        /// <summary>
        /// Gets account balance from a given address asynchronously
        /// </summary>
        /// <returns>AccountBalanceResponse with balance</returns>
        Task<AccountBalanceResponse> GetAccountBalanceAsync(AccountRequest acc);

        /// <summary>
        /// Gets account public key from a given address synchronously. 
        /// Only applicable when account session is already opened with /account/open
        /// Otherwise return empty.
        /// </summary>
        /// <returns>AccountBalanceResponse with public key</returns>
        AccountPublickeyResponse GetAccountPublickey(AccountRequest acc);

        /// <summary>
        /// Gets account public key from a given address asynchronously. 
        /// Only applicable when account session is already opened with /account/open
        /// Otherwise return empty.
        /// Alternatively, go to login.lisk.io, open your address. Run this api method.
        /// </summary>
        /// <returns>AccountBalanceResponse with public key</returns>
        Task<AccountPublickeyResponse> GetAccountPublickeyAsync(AccountRequest acc);

        /// <summary>
        /// Gets account delegates from a given address synchronously. 
        /// </summary>
        /// <returns>AccountBalanceResponse with delegates</returns>
        AccountDelegatesResponse GetAccountDelegates(AccountRequest acc);

        /// <summary>
        /// Gets account delegates from a given address asynchronously. 
        /// </summary>
        /// <returns>AccountBalanceResponse with delegates</returns>
        Task<AccountDelegatesResponse> GetAccountDelegatesAsync(AccountRequest acc);

        /// <summary>
        /// Gets account delegates fee from a given address synchronously. 
        /// </summary>
        /// <returns>AccountDelegatesFeeResponse with delegates fee</returns>
        FeeResponse GetAccountDelegatesFee(AccountRequest acc);

        /// <summary>
        /// Gets account delegates fee from a given address asynchronously. 
        /// </summary>
        /// <returns>AccountDelegatesFeeResponse with delegates fee</returns>
        Task<FeeResponse> GetAccountDelegatesFeeAsync(AccountRequest acc);

        /// <summary>
        /// Opens an account session
        /// </summary>
        /// <returns>OpenAccountResponse with account details</returns>
        OpenAccountResponse OpenAccount(OpenAccountRequest acc);

        /// <summary>
        /// Opens an account session
        /// </summary>
        /// <returns>OpenAccountResponse with account details</returns>
        Task<OpenAccountResponse> OpenAccountAsync(OpenAccountRequest acc);
    }
}