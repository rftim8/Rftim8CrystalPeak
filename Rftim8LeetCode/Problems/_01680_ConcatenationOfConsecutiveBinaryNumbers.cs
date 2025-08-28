using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.LeetCode.Data;
using Rftim8Convoy.Services.Static.CP.LeetCode.Data;

namespace Rftim8LeetCode.Problems
{
    public class _01680_ConcatenationOfConsecutiveBinaryNumbers : I_01680_ConcatenationOfConsecutiveBinaryNumbers
    {
        #region Static
        private readonly List<string>? data;

        public _01680_ConcatenationOfConsecutiveBinaryNumbers()
        {
            data = RftLeetCodeStaticData.Input_Test(testType: false, problemName: nameof(_01680_ConcatenationOfConsecutiveBinaryNumbers));
        }

        /// <summary>
        ///
        /// </summary>
        [Benchmark]
        public int PartOne() => PartOne0(data!);

        private static int PartOne0(List<string> input)
        {
            return 0;
        }

        /// <summary>
        ///
        /// </summary>        
        [Benchmark]
        public int PartTwo() => PartTwo0(data!);

        private static int PartTwo0(List<string> input)
        {
            return 0;
        }
        #endregion

        #region UnitTest
        public static int PartOne_Test(List<string> data) => PartOne0(data);

        public static int PartTwo_Test(List<string> data) => PartTwo0(data);
        #endregion

        #region Host
        private readonly IRftLeetCodeHostData? RftLeetCodeHostData;

        public _01680_ConcatenationOfConsecutiveBinaryNumbers(IHost host)
        {
            RftLeetCodeHostData = host.Services.GetRequiredService<IRftLeetCodeHostData>();
            data = RftLeetCodeHostData.Input_Test(problemName: nameof(_01680_ConcatenationOfConsecutiveBinaryNumbers));
        }

        public void PrintSolution()
        {
            Console.WriteLine(PartOne());
            Console.WriteLine(PartTwo());
        }
        #endregion
    }
}