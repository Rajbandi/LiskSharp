using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using LiskSharp.Core.Common;
using LiskSharp.Core.Extensions;

using System.IO.Compression;
using System.Linq;
using LiskSharp.DappMan.Common;
using LiskSharp.DappMan.Helpers;
using LiskSharp.Tests.Internals;
using NUnit.Framework;


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
        public static async void TestSdkLink()
        {
            var gitUrl = "https://github.com/LiskHQ/lisk-dapps-sdk";
            var repoName = gitUrl.Split("/".ToCharArray()).Last() + "-development";

            await DappManHelper.DownloadSdk(new GitOptions
            {
                FileName = repoName,
                GitUrl = gitUrl,
                ReplaceExisting = true,
                RootFolder = "c:\\Temp"
            });
        }

        
        [Test]
        public async void TestLocalStorage()
        {
          
           
        }
    }
}

