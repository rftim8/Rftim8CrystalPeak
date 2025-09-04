using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.LeetCode.Data;
using Rftim8Convoy.Services.Static.CP.LeetCode.Data;


namespace Rftim8LeetCode.Problems
{
    public class _01411_NumberOfWaysToPaintN×3Grid : I_01411_NumberOfWaysToPaintN×3Grid
    {
        #region Static
        private readonly List<string>? Input;

        public _01411_NumberOfWaysToPaintN×3Grid()
        {
            //Input = RftLeetCodeStaticData.Input_Test(testType: false, problemName: nameof(_01411_NumberOfWaysToPaintN×3Grid));
            Input = [.. RftResource._01411_NumberOfWaysToPaintN×3Grid_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
            DataCollector();
        }

        public void DataCollector()
        {

        }

        /// <summary>
        ///
        /// </summary>
        [Benchmark]
        public int PartOne() => PartOne0(Input!);

        private static int PartOne0(List<string> input)
        {
            return 0;
        }

        /// <summary>
        ///
        /// </summary>        
        [Benchmark]
        public int PartTwo() => PartTwo0(Input!);

        private static int PartTwo0(List<string> input)
        {
            return 0;
        }
        #endregion

        #region UnitTest
        public static int PartOne_Test(List<string> input) => PartOne0(input);

        public static int PartTwo_Test(List<string> input) => PartTwo0(input);
        #endregion

        #region Host
        private readonly IRftLeetCodeHostData? RftLeetCodeHostData;

        public _01411_NumberOfWaysToPaintN×3Grid(IHost host)
        {
            RftLeetCodeHostData = host.Services.GetRequiredService<IRftLeetCodeHostData>();
            Input = RftLeetCodeHostData.Input_Test(problemName: nameof(_01411_NumberOfWaysToPaintN×3Grid));
            DataCollector();
        }

        public void PrintSolution()
        {
            Console.WriteLine(PartOne());
            Console.WriteLine(PartTwo());
        }
        #endregion
    }
}

