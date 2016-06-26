using System.Diagnostics;
using LiskSharp.Core.Api;
using LiskSharp.Core.Api.Messages.Node;
using LiskSharp.Core.Api.Models;
using NUnit.Framework;

namespace LiskSharp.Tests
{
    /// <summary>
    /// This class contains all the api related test cases. 
    /// By default it uses login.lisk.io node . To use other nodes, just update init method with Ipaddress and port
    /// </summary>
    [TestFixture]
    public class LiskPeerApiTests
    {
        ILiskPeerApi _api;

        [TestFixtureSetUp]
        public void InitTests()
        {
            _api = new LiskPeerApi(new ApiInfo
            {
                //Host = "yourhostip",
                //Port = "port"
                UseHttps = true
            });
        

        }

        #region Peer related tests

        [Test]
        [Category("Peer")]
        public async void TestGetPeerList()
        {
            var response = await _api.GetPeerListAsync();
            Assert.IsTrue(response.Peers != null, $"Unable to retrieve peers. Response={response}");
            Debug.WriteLine(response);
        }

        [Test]
        [Category("Peer")]
        public async void TestGetBlocks()
        {
            var response = await _api.GetPeerBlocksAsync();
            
            Assert.IsTrue(response.Blocks != null, $"Unable to retrieve blocks. Response={response}");
            Debug.WriteLine(response.Blocks.Count);
        }

        [Test]
        [Category("Peer")]
        public async void TestGetHeight()
        {
            var response = await _api.GetPeerHeightAsync();

            Assert.IsTrue(response.Height != null, $"Unable to retrieve Height. Response={response}");
            Debug.WriteLine(response.Height);
        }
        #endregion

    }
}
