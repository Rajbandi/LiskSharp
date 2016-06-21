using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LiskSharp.Core.Common;
using LiskSharp.Core.Extensions;

namespace LiskSharp.Core.Api
{
    /// <summary>
    /// LiskApi contains equivalent api calls functionality of remote node.
    /// Use this api to access remote node api functionality
    /// </summary>
    public class LiskNodeApi
    {
        private readonly UriBuilder _url;

        private readonly HttpClient _client;

        public LiskNodeApi(ApiInfo info)
        {
            _url = new UriBuilder
            {
                Host = !string.IsNullOrWhiteSpace(info.Host) ? info.Host : Constants.DefaultHost,
                Scheme = info.UseHttps ? Constants.Https : Constants.Http
            };
            if (info.Port.HasValue)
            {
                _url.Port = info.Port.Value;
            }

            _client = new HttpClient();
        }

        #region delegates related api

        /// <summary>
        /// Get all delegates from a node synchronously 
        /// </summary>
        /// <returns>Peers response with peer list</returns>
        public DelegatesResponse GetDelegates()
        {
            var response = GetDelegatesAsync().GetAwaiter().GetResult();
            return response;
        }

        
        /// <summary>
        /// Get all delegates from a node synchronously 
        /// </summary>
        /// <returns>Peers response with peer list</returns>
        public async Task<DelegatesResponse> GetDelegatesAsync()
        {
            _url.Path = Constants.ApiGetDelegates;
            var response = await _client.GetJsonAsync<DelegatesResponse>(_url.ToString());
            ResetPath();
            return response;
        }

        #endregion

        #region Peer related api 
        /// <summary>
        /// Get all peers from a node synchronously 
        /// </summary>
        /// <returns>Peers response with peer list</returns>
        public PeersResponse GetPeers()
        {
            var peerResponse = GetPeersAsync().GetAwaiter().GetResult();
            return peerResponse;
        }

        /// <summary>
        /// Get all peers from a node asynchronously 
        /// </summary>
        /// <returns>Peers response with peer list</returns>
        public async Task<PeersResponse> GetPeersAsync()
        {
            _url.Path = Constants.ApiGetPeers;

            var peersResponse = await _client.GetJsonAsync<PeersResponse>(_url.ToString());

            ResetPath();

            return peersResponse;
        }

        /// <summary>
        /// Get single peer related information from node synchronously
        /// </summary>
        /// <returns></returns>
        public PeerResponse GetPeer(Peer peer)
        {
            var peerResponse = GetPeerAsync(peer).GetAwaiter().GetResult();
            return peerResponse;
        }

        /// <summary>
        /// Get single peer related information from node asynchronously
        /// </summary>
        /// <returns></returns>
        public async Task<PeerResponse> GetPeerAsync(Peer peer)
        {
            _url.Path = Constants.ApiGetPeer;
            _url.Query = string.Format("ip={0}&port={1}", peer.IpAddress, peer.Port);

            var peerResponse = await _client.GetJsonAsync<PeerResponse>(_url.ToString());

            ResetPath();

            return peerResponse;
        }

        /// <summary>
        /// Get single peer related information from node synchronously
        /// </summary>
        /// <returns></returns>
        public VersionResponse GetVersion()
        {
            var version = GetVersionAsync().GetAwaiter().GetResult();
            return version;
        }

        /// <summary>
        /// Get single peer related information from node asynchronously
        /// </summary>
        /// <returns></returns>
        public async Task<VersionResponse> GetVersionAsync()
        {
            _url.Path = Constants.ApiVersion;

            var peerResponse = await _client.GetJsonAsync<VersionResponse>(_url.ToString());

            ResetPath();

            return peerResponse;
        }
        #endregion

        #region private methods
        /// <summary>
        /// Resets url path and query
        /// </summary>
        private void ResetPath()
        {
            _url.Path = string.Empty;
            _url.Query = string.Empty;
        }

        #endregion

        #region public properties

        /// <summary>
        /// Returns current url of api.
        /// </summary>
        public string Url
        {
            get
            {
                return _url.ToString();
            }
        }

        #endregion
    }
}
