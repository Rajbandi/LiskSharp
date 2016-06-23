#region copyright
// <copyright file="Constants.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
namespace LiskSharp.Core.Common
{
    /// <summary>
    /// Defines all lisk constants
    /// </summary>
    public class Constants
    {
        #region general constants

        public const int ActiveDelegates = 101;

        public const string Https = "https";

        public const string Http = "http";

        public const string DefaultHost = "login.lisk.io";

        #endregion

        #region Api related constants

        public const string ApiGetPeers = "/api/peers";
        public const string ApiGetPeer = "/api/peers/get";
        public const string ApiVersion = "/api/peers/version";

        public const string ApiGetDelegates = "/api/delegates";
        public const string ApiGetDelegate = "/api/delegates/get";
        public const string ApiGetDelegateVoters = "/api/delegates/voters";
        public const string ApiGetDelegateFee = "/api/delegates/fee";
        public const string ApiGetDelegateForgeAccount = "/api/delegates/forging/getForgedByAccount";

        public const string ApiGetBlocks = "/api/blocks";
        public const string ApiGetBlocksBlock = "/api/blocks/get";
        public const string ApiGetBlocksHeight = "/api/blocks/getHeight";
        public const string ApiGetBlocksFee = "/api/blocks/getFee";
        public const string ApiGetBlocksFees = "/api/blocks/getFees";
        public const string ApiGetBlocksNethash = "/api/blocks/getNethash";
        public const string ApiGetBlocksMilestone = "/api/blocks/getMilestone";
        public const string ApiGetBlocksReward = "/api/blocks/getReward";
        public const string ApiGetBlocksSupply = "/api/blocks/getSupply";
        public const string ApiGetBlocksStatus = "/api/blocks/getStatus";

        public const string ApiGetAccount = "/api/accounts";
        public const string ApiGetAccountDelegates = "/api/accounts/delegates";
        public const string ApiGetAccountDelegatesFee = "/api/accounts/delegates/fee";
        public const string ApiGetAccountPublickey = "/api/accounts/getPublickey";
        public const string ApiGetAccountBalance = "/api/accounts/getBalance";
        public const string ApiPostAccountOpen = "/api/accounts/open";

        public const string ApiGetSignatureFee = "/api/signatures/fee";

        public const string ApiGetTransactions = "/api/transactions";
        public const string ApiGetTransaction = "/api/transactions/get";
        public const string ApiGetUnconfirmedTransaction = "/api/transactions/unconfirmed/get";
        public const string ApiGetUnconfirmedTransactions = "/api/transactions/unconfirmed";

        #endregion

    }
}
