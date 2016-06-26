using System.Threading.Tasks;
using LiskSharp.Core.Api.Messages.Peer;

namespace LiskSharp.Core.Api
{
    public interface ILiskPeerApi
    {
        /// <summary>
        /// Gets peer list from remote peer synchronously
        /// </summary>
        /// <returns>Peers list</returns>
        PeerListResponse GetPeerList();

        /// <summary>
        /// Gets peer list from remote peer asynchronously
        /// </summary>
        /// <returns>Peers list</returns>
        Task<PeerListResponse> GetPeerListAsync();

        /// <summary>
        /// Gets peer blocks from remote peer synchronously
        /// </summary>
        /// <returns>Blocks list</returns>
        PeerBlocksResponse GetPeerBlocks();

        /// <summary>
        /// Gets peer blocks from remote peer asynchronously
        /// </summary>
        /// <returns>Blocks list</returns>
        Task<PeerBlocksResponse> GetPeerBlocksAsync();

        Task<PeerHeightResponse> GetPeerHeightAsync();
    }
}