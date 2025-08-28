using Rftim8LeetCode.CP;

namespace Rftim8LeetCode
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            #region Benchmarking
            //await RftBenchmark.InitBenchmark();
            #endregion

            #region Hosting
            await CPHostMain.InitHost(args);
            //await DataHostMain.InitHost(args);
            //await DotnetHostMain.InitHost(args);
            #endregion

            //RftFileContentManager.CleanCodeForcesProblemNames();
        }
    }
}
