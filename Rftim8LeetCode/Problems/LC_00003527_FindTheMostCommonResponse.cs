using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.LeetCode.Data;
using Rftim8Convoy.Services.Static.CP.LeetCode.Data;


namespace Rftim8LeetCode.Problems
{
    public class LC_00003527_FindTheMostCommonResponse : ILC_00003527_FindTheMostCommonResponse
    {
        #region Static
        private readonly List<string>? Input;

        public LC_00003527_FindTheMostCommonResponse()
        {
            //Input = RftLeetCodeStaticData.Input_Test(testType: false, problemName: nameof(LC_00003527_FindTheMostCommonResponse));
            Input = [.. RftLCResources.LC_00003527_FindTheMostCommonResponse_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
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

        public LC_00003527_FindTheMostCommonResponse(IHost host)
        {
            RftLeetCodeHostData = host.Services.GetRequiredService<IRftLeetCodeHostData>();
            Input = RftLeetCodeHostData.Input_Test(problemName: nameof(LC_00003527_FindTheMostCommonResponse));
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

