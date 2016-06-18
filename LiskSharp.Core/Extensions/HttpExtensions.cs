using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LiskSharp.Core.Common;

namespace LiskSharp.Core.Extensions
{
    public static class HttpExtensions
    {

        public static async Task<byte[]> DownloadFileAsync(this HttpClient client, HttpOptions options)
        {
            var token = options.Token;
            var progress = options.Progress;

            var response = await client.GetAsync(options.Url, HttpCompletionOption.ResponseHeadersRead, token);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(string.Format("The request returned with HTTP status code {0}", response.StatusCode));
            }

            var total = response.Content.Headers.ContentLength.HasValue ? response.Content.Headers.ContentLength.Value : -1L;
            var canReportProgress = total != -1 && progress != null;

            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                var totalRead = 0;
                var buffer = new byte[4096];
                var isMoreToRead = true;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (BinaryWriter writer = new BinaryWriter(ms))
                    {

                        do
                        {
                            token.ThrowIfCancellationRequested();

                            var read = await stream.ReadAsync(buffer, 0, buffer.Length, token);

                            if (read == 0)
                            {
                                isMoreToRead = false;
                            }
                            else
                            {
                                //var data = new byte[read];
                                //buffer.ToList().CopyTo(0, data, 0, read);
                                //Buffer.BlockCopy(buffer, 0, data, totalRead, read);
                                writer.Write(buffer);
                                totalRead += read;

                                if (canReportProgress)
                                {
                                    progress.Report((totalRead * 1d) / (total * 1d) * 100);
                                }
                            }
                        } while (isMoreToRead);
                    }
                    return ms.ToArray();
                }

            }
        }
    }
}
