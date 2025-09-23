using Rftim8CodeForces.CP;

namespace Rftim8CodeForces
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
            #endregion
        }
    }
}
