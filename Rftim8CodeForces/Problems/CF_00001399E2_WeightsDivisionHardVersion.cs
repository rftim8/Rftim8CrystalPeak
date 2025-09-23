using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.CodeForces.Data;
using Rftim8Convoy.Services.Static.CP.CodeForces.Data;

namespace Rftim8CodeForces.Problems
{
    public class CF_00001399E2_WeightsDivisionHardVersion : ICF_00001399E2_WeightsDivisionHardVersion
    {
        #region Static
        private readonly List<string>? Input = [];
        private readonly List<char[][]>? boards = [];
        private readonly List<bool>? results = [];

        public CF_00001399E2_WeightsDivisionHardVersion()
        {
            Input = RftCodeForcesStaticData.Input_Test(testType: true, problemName: nameof(CF_00001399E2_WeightsDivisionHardVersion));
            //Input = [.. CF_Resources.CF_00001399E2_WeightsDivisionHardVersion_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
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
        public bool Solution_0() => CF_00001399E2_WeightsDivisionHardVersion_0(Board!);

        private static bool CF_00001399E2_WeightsDivisionHardVersion_0(char[][] board)
        {
            return true;
        }
        #endregion

        #region UnitTest
        public static bool Solution_0_Test(char[][] board) => CF_00001399E2_WeightsDivisionHardVersion_0(board);

        #endregion

        #region Host
        private readonly IRftCodeForcesHostData? RftCodeForcesHostData;

        public CF_00001399E2_WeightsDivisionHardVersion(IHost host)
        {
            RftCodeForcesHostData = host.Services.GetRequiredService<IRftCodeForcesHostData>();
            Input = RftCodeForcesHostData.Input_Test(problemName: nameof(CF_00001399E2_WeightsDivisionHardVersion));
            DataCollector();
        }

        public void PrintSolution()
        {
            for (int i = 0; i < boards!.Count; i++)
            {
                bool actual = CF_00001399E2_WeightsDivisionHardVersion_0(boards[i]);
                Console.WriteLine($"Solution 0: Testcase {i + 1}: Expected = {results![i]} => Actual: {actual}");
            }
        }
        #endregion
    }
}
