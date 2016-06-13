using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Common
{
    public class DappResult
    {
        public string GenesisBlock { get; set; }

        public string BlockChain { get; set; }

        public string Error { get; set; }

        public string Path { get; set; }

        public bool IsGit { get; set; }
    }
}
