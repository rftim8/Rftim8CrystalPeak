using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.AdventOfCode.Data;
using Rftim8Convoy.Services.Static.CP.AdventOfCode.Data;

namespace Rftim8AdventOfCode.Problems
{
    public class AOC_00000008_Y20_HandheldHalting : IAOC_00000008_Y20_HandheldHalting
    {
        #region Static
        private readonly List<string>? Input = [];
        private readonly List<char[][]>? boards = [];
        private readonly List<bool>? results = [];

        public AOC_00000008_Y20_HandheldHalting()
        {
            //Input = RftAdventOfCodeStaticData.Input_Test(testType: true, problemName: nameof(AOC_00000008_Y20_HandheldHalting));
            //Input = [.. AOC_Resources.AOC_00000008_Y20_HandheldHalting_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
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
        
        [Benchmark]
        public bool Solution_0() => AOC_00000008_Y20_HandheldHalting_0(Board!);

        private static bool AOC_00000008_Y20_HandheldHalting_0(char[][] board)
        {
            return true;
        }
        #endregion

        #region UnitTest
        public static bool Solution_0_Test(char[][] board) => AOC_00000008_Y20_HandheldHalting_0(board);

        #endregion

        #region Host
        private readonly IRftAdventOfCodeHostData? RftAdventOfCodeHostData;

        public AOC_00000008_Y20_HandheldHalting(IHost host)
        {
            RftAdventOfCodeHostData = host.Services.GetRequiredService<IRftAdventOfCodeHostData>();
            Input = RftAdventOfCodeHostData.Input_Test(problemName: nameof(AOC_00000008_Y20_HandheldHalting));
            DataCollector();
        }

        public void PrintSolution()
        {
            for (int i = 0; i < boards!.Count; i++)
            {
                bool actual = AOC_00000008_Y20_HandheldHalting_0(boards[i]);
                Console.WriteLine($"Solution 0: Testcase {i + 1}: Expected = {results![i]} => Actual: {actual}");
            }
        }
        #endregion
    }
}
