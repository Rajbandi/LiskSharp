using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LiskSharp.Core.Api.Messages.Peer;
using LiskSharp.Core.Api.Models;
using LiskSharp.Core.Common;
using LiskSharp.Core.Extensions;

namespace LiskSharp.Core.Api
{
    public class LiskPeerApi : ILiskPeerApi
    {
        #region private properties

        private readonly UriBuilder _url;
        private readonly HttpClient _client;

        #endregion

        #region constructors

        public LiskPeerApi(ApiInfo info)
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
        
        #endregion

        #region peer related api

        /// <summary>
        /// Gets peer list from remote peer synchronously
        /// </summary>
        /// <returns>Peers list</returns>
        public PeerListResponse GetPeerList()
        {
            var response = GetPeerListAsync().GetAwaiter().GetResult();
            return response;
        }

        /// <summary>
        /// Gets peer list from remote peer asynchronously
        /// </summary>
        /// <returns>Peers list</returns>
        public async Task<PeerListResponse> GetPeerListAsync()
        {
            var req = new PeerBaseRequest();
            _url.Path = Constants.PeerGetList;
            var headerValues = req.GetHeaderValues().ToList();
            AddHeaders(headerValues);
            var response = await _client.GetJsonAsync<PeerListResponse>(_url.ToString());
            ResetRequest(headerValues);
            return response;
        }

        /// <summary>
        /// Gets peer blocks from remote peer synchronously
        /// </summary>
        /// <returns>Blocks list</returns>
        public PeerBlocksResponse GetPeerBlocks()
        {
            var response = GetPeerBlocksAsync().GetAwaiter().GetResult();
            return response;
        }

        /// <summary>
        /// Gets peer blocks from remote peer asynchronously
        /// </summary>
        /// <returns>Blocks list</returns>
        public async Task<PeerBlocksResponse> GetPeerBlocksAsync()
        {
            var req = new PeerBaseRequest();
            _url.Path = Constants.PeerGetBlocks;
            var headerValues = req.GetHeaderValues().ToList();
            AddHeaders(headerValues);
            var response = await _client.GetJsonAsync<PeerBlocksResponse>(_url.ToString());
            ResetRequest(headerValues);
            return response;
        }

        #endregion

        #region private methods

        private void AddHeaders(IEnumerable<HeaderValue> headerValues)
        {
            foreach (var headerValue in headerValues)
            {
                _client.DefaultRequestHeaders.Add(headerValue.Name, headerValue.Value);
            }
        }

        /// <summary>
        /// Resets url path and headers
        /// </summary>
        private void ResetRequest(IEnumerable<HeaderValue> headerValues)
        {
            _url.Path = string.Empty;
            if (headerValues != null)
            {
                foreach (var headerValue in headerValues)
                {
                    if (_client.DefaultRequestHeaders.Contains(headerValue.Name))
                        _client.DefaultRequestHeaders.Remove(headerValue.Name);
                }
            }
        }

        #endregion
    }
}
