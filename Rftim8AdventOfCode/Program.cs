using Rftim8AdventOfCode.Benchmarking;
using Rftim8AdventOfCode.CP;

namespace Rftim8AdventOfCode
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            #region Benchmarking
            await RftBenchmark.InitBenchmark();
            #endregion

            #region Hosting
            //await CPHostMain.InitHost(args);
            #endregion
        }
    }
}
