using Rftim8Atlas;
using Rftim8LeetCode.CP;

namespace Rftim8LeetCode
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            #region Static
            //_ = new LC_00000036_ValidSudoku();
            #endregion

            #region Hosting
            await CPHostMain.InitHost(args);
            //await DataHostMain.InitHost(args);
            //await DotnetHostMain.InitHost(args);
            #endregion

            #region Benchmarking
            //await RftBenchmark.InitBenchmark();
            #endregion
        }
    }
}
