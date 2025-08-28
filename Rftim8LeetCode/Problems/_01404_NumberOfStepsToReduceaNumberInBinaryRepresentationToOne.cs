using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.LeetCode.Data;
using Rftim8Convoy.Services.Static.CP.LeetCode.Data;

namespace Rftim8LeetCode.Problems
{
    public class _01404_NumberOfStepsToReduceaNumberInBinaryRepresentationToOne : I_01404_NumberOfStepsToReduceaNumberInBinaryRepresentationToOne
    {
        #region Static
        private readonly List<string>? data;

        public _01404_NumberOfStepsToReduceaNumberInBinaryRepresentationToOne()
        {
            data = RftLeetCodeStaticData.Input_Test(testType: false, problemName: nameof(_01404_NumberOfStepsToReduceaNumberInBinaryRepresentationToOne));
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

        public _01404_NumberOfStepsToReduceaNumberInBinaryRepresentationToOne(IHost host)
        {
            RftLeetCodeHostData = host.Services.GetRequiredService<IRftLeetCodeHostData>();
            data = RftLeetCodeHostData.Input_Test(problemName: nameof(_01404_NumberOfStepsToReduceaNumberInBinaryRepresentationToOne));
        }

        public void PrintSolution()
        {
            Console.WriteLine(PartOne());
            Console.WriteLine(PartTwo());
        }
        #endregion
    }
}