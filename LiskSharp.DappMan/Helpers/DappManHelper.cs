using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LiskSharp.Core.Common;
using LiskSharp.DappMan.Common;
using LiskSharp.DappMan.Internals;

namespace LiskSharp.DappMan.Helpers
{
    public static class DappManHelper
    {
        public static string ValidateDapp(Dapp dapp)
        {
            var error = string.Empty;
            if (string.IsNullOrWhiteSpace(dapp.Name))
            {
                error = "DApp name is too short, minimum is 1 character";
            }
            else if (dapp.Name.Length > 32)
            {
                error = "DApp name is too long, maximum is 32 characters";
            }
            else
            if (!string.IsNullOrWhiteSpace(dapp.Description) && dapp.Description.Length > 160)
            {
                error = "DApp description is too long, maximum is 160 characters";
            }

            return error;
        }
        public static bool IsLinux
        {
            get
            {
                int p = (int)Environment.OSVersion.Platform;
                return (p == 4) || (p == 6) || (p == 128);
            }
        }
        public static  Task DownloadSdk(GitOptions options)
        {

            return Task.Run(async () =>
            {
                var url = options.GitUrl+ "/archive/development.zip";
                 
                var folderPath = options.RootFolder;
                var fileName = options.FileName.Replace(".zip", "")+"-development";

                string zipPath, filePath;
                //if (!IsLinux)
                //{
                zipPath = string.Format("{0}\\{1}", folderPath, fileName);
                filePath = string.Format("{0}.zip", zipPath);
                //}

                if (options.ReplaceExisting)
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }

                    if (Directory.Exists(zipPath))
                    {
                        Directory.Delete(zipPath, true);

                    }
                }


                using (var client = new HttpClient())
                {
                    var result = await client.GetAsync(url);
                    result.EnsureSuccessStatusCode();
                    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        await result.Content.CopyToAsync(fileStream);
                        fileStream.Close();
                    }
                }

                if (File.Exists(filePath))
                {
                    var unzip = new Unzip(filePath);
                    unzip.ExtractToDirectory(folderPath);
                }
            });

        }
    }
}
