namespace LiskSharp.Core.Api
{
    /// <summary>
    /// ApiInfo contains api related information
    /// </summary>
    public class ApiInfo
    {
        /// <summary>
        /// if true, uses https otherwise http
        /// </summary>
        public bool UseHttps { get; set; }

        /// <summary>
        /// Domain or Ip 
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Port 
        /// </summary>
        public int? Port { get; set; }
    }
}
