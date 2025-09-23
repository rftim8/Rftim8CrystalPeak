using Rftim8CodinGame.CP;
using Rftim8CodinGame.Problems;

namespace Rftim8CodinGame
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            #region Static
            //_ = new CG_00000001_1000000000DWORLD();
            #endregion

            #region Hosting
            await CPHostMain.InitHost(args);
            #endregion

            #region Benchmarking
            //await RftBenchmark.InitBenchmark();
            #endregion
        }
    }
}
