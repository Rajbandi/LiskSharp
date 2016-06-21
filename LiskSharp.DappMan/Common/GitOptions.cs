namespace LiskSharp.DappMan.Common
{
    public class GitOptions
    {
        public string GitUrl { get; set; }
        public string FileName { get; set; }

        public string RootFolder { get; set; }

        public string ExtractToFolder { get; set; }

        public bool ReplaceExisting { get; set; }
    }
}
