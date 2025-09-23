using Rftim8CodeForces.Benchmarking;
using Rftim8CodeForces.CP;
using Rftim8CodeForces.Problems;

namespace Rftim8CodeForces
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            #region Static
            //_ = new CF_00000002A_Winner();
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
