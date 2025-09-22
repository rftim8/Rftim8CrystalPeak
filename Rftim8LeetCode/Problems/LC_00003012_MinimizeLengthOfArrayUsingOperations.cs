using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.LeetCode.Data;
using Rftim8Convoy.Services.Static.CP.LeetCode.Data;

namespace Rftim8LeetCode.Problems
{
    public class LC_00003012_MinimizeLengthOfArrayUsingOperations : ILC_00003012_MinimizeLengthOfArrayUsingOperations
    {
        #region Static
        private readonly List<string>? Input;
        private readonly List<char[][]>? boards = [];
        private readonly List<bool>? results = [];

        public LC_00003012_MinimizeLengthOfArrayUsingOperations()
        {
            //Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00003012_MinimizeLengthOfArrayUsingOperations));
            Input = [.. LC_Resources.LC_00003012_MinimizeLengthOfArrayUsingOperations_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
            DataCollector();
            PrintSolution();
        }

        public void DataCollector()
        {
            int _n = int.Parse(Input![0]);
            int _m = int.Parse(Input[1]);

            for (int i = 2; i < _n * _m + 2; i += _m)
            {

            }
        }

        [ParamsSource(nameof(BoardDataSets))]
        public char[][]? Board { get; set; }

        public IEnumerable<char[][]> BoardDataSets() => boards!;
        
        /// <summary>
        ///
        /// </summary>
        [Benchmark]
        public int Solution_0() => LC_00003012_MinimizeLengthOfArrayUsingOperations_0(Input!);

        private static int LC_00003012_MinimizeLengthOfArrayUsingOperations_0(List<string> input)
        {
            return 0;
        }

        /// <summary>
        ///
        /// </summary>        
        [Benchmark]
        public int Solution_1() => LC_00003012_MinimizeLengthOfArrayUsingOperations_1(Input!);

        private static int LC_00003012_MinimizeLengthOfArrayUsingOperations_1(List<string> input)
        {
            return 0;
        }
        #endregion

        #region UnitTest
        public static int Solution_0_Test(List<string> data) => LC_00003012_MinimizeLengthOfArrayUsingOperations_0(data);

        public static int Solution_1_Test(List<string> data) => LC_00003012_MinimizeLengthOfArrayUsingOperations_1(data);
        #endregion

        #region Host
        private readonly IRftLeetCodeHostData? RftLeetCodeHostData;

        public LC_00003012_MinimizeLengthOfArrayUsingOperations(IHost host)
        {
            RftLeetCodeHostData = host.Services.GetRequiredService<IRftLeetCodeHostData>();
            Input = RftLeetCodeHostData.Input_Test(problemName: nameof(LC_00003012_MinimizeLengthOfArrayUsingOperations));
            DataCollector();
        }

        public void PrintSolution()
        {
            for (int i = 0; i < boards!.Count; i++)
            {
                int actual = LC_00003012_MinimizeLengthOfArrayUsingOperations_0([]);
                Console.WriteLine($"Solution 0: Testcase {i + 1}: Expected = {results![i]} => Actual: {actual}");
                actual = LC_00003012_MinimizeLengthOfArrayUsingOperations_1([]);
                Console.WriteLine($"Solution 1: Testcase {i + 1}: Expected = {results![i]} => Actual: {actual}");
            }
        }
        #endregion
    }
}
