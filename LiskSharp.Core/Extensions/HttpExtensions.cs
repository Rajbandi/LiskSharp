using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LiskSharp.Core.Common;
using Newtonsoft.Json;

namespace LiskSharp.Core.Extensions
{
    public static class HttpExtensions
    {
        public static async Task<T> GetJsonAsync<T>(this HttpClient client, string url)
        {
            var result = await client.GetAsync(url);
            result.EnsureSuccessStatusCode();
            if (result.Content != null)
            {
                var json = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(json);
            }
            return default(T);
        }

    }
}
