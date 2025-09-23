using Rftim8AdventOfCode.Benchmarking;
using Rftim8AdventOfCode.CP;
using Rftim8AdventOfCode.Problems;

namespace Rftim8AdventOfCode
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            #region Static
            //_ = new AOC_00000001_Y15_NotQuiteLisp();
            #endregion

            #region Hosting
            //await CPHostMain.InitHost(args);
            #endregion

            #region Benchmarking
            await RftBenchmark.InitBenchmark();
            #endregion
        }
    }
}
