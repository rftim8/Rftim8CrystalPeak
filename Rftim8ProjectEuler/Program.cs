using Rftim8ProjectEuler.Benchmarking;
using Rftim8ProjectEuler.CP;
using Rftim8ProjectEuler.Problems;

namespace Rftim8ProjectEuler
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            #region Static
            //_ = new PE_00000002_EvenFibonacciNumbers();
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
