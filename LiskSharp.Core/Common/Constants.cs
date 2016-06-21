namespace LiskSharp.Core.Common
{
    /// <summary>
    /// Defines all lisk constants
    /// </summary>
    public class Constants
    {
        public const int ActiveDelegates = 101;

        public const string Https = "https";

        public const string Http = "http";

        public const string DefaultHost = "login.lisk.io";


        #region Api related constants

        public const string ApiGetPeers = "/api/peers";
        public const string ApiGetPeer = "/api/peers/get";
        public const string ApiVersion = "/api/peers/version";

        public const string ApiGetDelegates = "/api/delegates";
        public const string ApiGetDelegate = "/api/delegates/get";

        public const string ApiGetDelegateVoters = "/api/delegates/voters";
        public const string ApiGetDelegateFee = "/api/delegates/fee";
        public const string ApiGetDelegateForgeAccount = "/api/delegates/forging/getForgedByAccount";

        #endregion

    }
}
