using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;

using NUnit.Framework;
using LiskSharp.Core.Common;
using LiskSharp.Core.Extensions;

namespace LiskSharp.Tests
{
    [TestFixture]
    public class DappTests
    {

        [TestFixtureSetUp]
        public void Init()
        {
        }

        [Test]
        public async void TestSdkClone()
        {
        }

        [Test]
        public async void TestSdkLink()
        {
            var client = new HttpClient();
            var progress = new Progress<double>();
            progress.ProgressChanged += (sender, d) =>
            {
                Debug.WriteLine("\r%{0:N0}", d);

            };
            var options = new HttpOptions
            {
                Url = "https://github.com/LiskHQ/lisk-dapps-sdk/archive/development.zip",
                Token = new CancellationToken(),
                Progress = progress
            };
            var fileBytes = await client.DownloadFileAsync(options);

            Debug.WriteLine(fileBytes.Length);
        }

        [Test]
        public async void TestLocalStorage()
        {
          
           
        }
    }
}

