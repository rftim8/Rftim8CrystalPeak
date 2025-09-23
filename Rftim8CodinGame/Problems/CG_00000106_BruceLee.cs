using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.CodinGame.Data;
using Rftim8Convoy.Services.Static.CP.CodinGame.Data;

namespace Rftim8CodinGame.Problems
{
    public class CG_00000106_BruceLee : ICG_00000106_BruceLee
    {
        #region Static
        private readonly List<string>? Input = [];
        private readonly List<char[][]>? boards = [];
        private readonly List<bool>? results = [];

        public CG_00000106_BruceLee()
        {
            Input = RftCodinGameStaticData.Input_Test(testType: true, problemName: nameof(CG_00000106_BruceLee));
            //Input = [.. CF_Resources.CG_00000106_BruceLee_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
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
        public bool Solution_0() => CG_00000106_BruceLee_0(Board!);

        private static bool CG_00000106_BruceLee_0(char[][] board)
        {
            return true;
        }
        #endregion

        #region UnitTest
        public static bool Solution_0_Test(char[][] board) => CG_00000106_BruceLee_0(board);

        #endregion

        #region Host
        private readonly IRftCodinGameHostData? RftCodinGameHostData;

        public CG_00000106_BruceLee(IHost host)
        {
            RftCodinGameHostData = host.Services.GetRequiredService<IRftCodinGameHostData>();
            Input = RftCodinGameHostData.Input_Test(problemName: nameof(CG_00000106_BruceLee));
            DataCollector();
        }

        public void PrintSolution()
        {
            for (int i = 0; i < boards!.Count; i++)
            {
                bool actual = CG_00000106_BruceLee_0(boards[i]);
                Console.WriteLine($"Solution 0: Testcase {i + 1}: Expected = {results![i]} => Actual: {actual}");
            }
        }
        #endregion
    }
}
