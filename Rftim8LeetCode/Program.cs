using Rftim8Atlas;
using Rftim8LeetCode.Benchmarking;
using Rftim8LeetCode.CP;
using Rftim8LeetCode.Problems;

namespace Rftim8LeetCode
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            #region Static
            //_ = new LC_00000036_ValidSudoku();
            //_ = new LC_00003688_BitwiseOROfEvenNumbersInAnArray();
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
