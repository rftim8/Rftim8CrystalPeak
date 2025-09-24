using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.ProjectEuler.Data;
using Rftim8Convoy.Services.Static.CP.ProjectEuler.Data;

namespace Rftim8ProjectEuler.Problems
{
    public class PE_00000102_TriangleContainment : IPE_00000102_TriangleContainment
    {
        #region Static
        private readonly List<string>? Input;
        private readonly List<char[][]>? boards = [];
        private readonly List<bool>? results = [];

        public PE_00000102_TriangleContainment()
        {
            Input = RftProjectEulerStaticData.Input_Test(testType: true, problemName: nameof(PE_00000102_TriangleContainment));
            //Input = [.. RftLCResources.PE_00000102_TriangleContainment_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
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
        public int Solution_0() => PE_00000102_TriangleContainment_0(Input!);

        private static int PE_00000102_TriangleContainment_0(List<string> input)
        {
            return 0;
        }

        /// <summary>
        ///
        /// </summary>        
        [Benchmark]
        public int Solution_1() => PE_00000102_TriangleContainment_1(Input!);

        private static int PE_00000102_TriangleContainment_1(List<string> input)
        {
            return 0;
        }
        #endregion

        #region UnitTest
        public static int Solution_0_Test(List<string> data) => PE_00000102_TriangleContainment_0(data);

        public static int Solution_1_Test(List<string> data) => PE_00000102_TriangleContainment_1(data);
        #endregion

        #region Host
        private readonly IRftProjectEulerHostData? RftProjectEulerHostData;

        public PE_00000102_TriangleContainment(IHost host)
        {
            RftProjectEulerHostData = host.Services.GetRequiredService<IRftProjectEulerHostData>();
            Input = RftProjectEulerHostData.Input_Test(problemName: nameof(PE_00000102_TriangleContainment));
            DataCollector();
        }

        public void PrintSolution()
        {
            for (int i = 0; i < boards!.Count; i++)
            {
                int actual = PE_00000102_TriangleContainment_0([]);
                Console.WriteLine($"Solution 0: Testcase {i + 1}: Expected = {results![i]} => Actual: {actual}");
                actual = PE_00000102_TriangleContainment_1([]);
                Console.WriteLine($"Solution 1: Testcase {i + 1}: Expected = {results![i]} => Actual: {actual}");
            }
        }
        #endregion
    }
}
