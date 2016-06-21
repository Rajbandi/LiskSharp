using System.Diagnostics;
using LiskSharp.Core.Api;
using LiskSharp.Core.Common;
using NUnit.Framework;

namespace LiskSharp.Tests
{
    [TestFixture]
    public  class LiskApiTests
    {
        private LiskNodeApi _api;
        [TestFixtureSetUp]
        public void Init()
        {
            _api = new LiskNodeApi(new ApiInfo
            {
                UseHttps = true
            });

        }

        #region Peer related tests

        [Test]
        public async void GetPeersTest()
        {
            var peers = await _api.GetPeersAsync();
            Debug.WriteLine(peers);
        }

        [Test]
        public async void GetPeerTest()
        {
            var peer = await _api.GetPeerAsync(new Peer
            {
                IpAddress = "104.251.218.222",
                Port = 8000
            });
            Debug.WriteLine(peer);
        }

        [Test]
        public async void GetVersion()
        {
            var version = await _api.GetVersionAsync();
            Debug.WriteLine(version);
        }
        #endregion

        #region Delegates related tests

        [Test]
        public async void GetDelegates()
        {
            var response = await _api.GetDelegatesAsync();
            Debug.WriteLine(response);
        }
        #endregion

    }
}
