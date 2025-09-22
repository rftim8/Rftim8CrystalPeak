using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.AdventOfCode.Data;
using Rftim8Convoy.Services.Static.CP.AdventOfCode.Data;

namespace Rftim8AdventOfCode.Problems
{
    public class AOC_00000001_Y15_NotQuiteLisp : IAOC_00000001_Y15_NotQuiteLisp
    {
        #region Static
        private readonly List<string>? Input = [];

        public AOC_00000001_Y15_NotQuiteLisp()
        {
            //Input = RftAdventOfCodeStaticData.Input_Test(testType: true, problemName: nameof(AOC_00000001_Y15_NotQuiteLisp));
            Input = [.. AOC_Resources.AOC_00000001_Y15_NotQuiteLisp_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
            PrintSolution();
        }

        [Benchmark]
        public int Solution_0() => AOC_00000001_Y15_NotQuiteLisp_0(Input!);

        private static int AOC_00000001_Y15_NotQuiteLisp_0(List<string> input)
        {
            string data = input[0];
            int r = 0;

            for (int i = 0; i < data.Length; i++)
            {
                r = data[i] == '(' ? r + 1 : r - 1;
            }

            return r;
        }

        [Benchmark]
        public int Solution_1() => AOC_00000001_Y15_NotQuiteLisp_1(Input!);

        private static int AOC_00000001_Y15_NotQuiteLisp_1(List<string> input)
        {
            string data = input[0];
            int r = 0;
            int firstBasement = 0;
            bool found = false;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '(') r++;
                else
                {
                    r--;

                    if (!found)
                    {
                        if (r < 0)
                        {
                            firstBasement = i;
                            found = true;
                        }
                    }
                }
            }

            return firstBasement + 1;
        }
        #endregion

        #region UnitTest
        public static int Solution_0_Test(List<string> input) => AOC_00000001_Y15_NotQuiteLisp_0(input);
        public static int Solution_1_Test(List<string> input) => AOC_00000001_Y15_NotQuiteLisp_1(input);
        #endregion

        #region Host
        private readonly IRftAdventOfCodeHostData? RftAdventOfCodeHostData;

        public AOC_00000001_Y15_NotQuiteLisp(IHost host)
        {
            RftAdventOfCodeHostData = host.Services.GetRequiredService<IRftAdventOfCodeHostData>();
            Input = RftAdventOfCodeHostData.Input_Test(problemName: nameof(AOC_00000001_Y15_NotQuiteLisp));
        }

        public void PrintSolution()
        {
            Console.WriteLine(AOC_00000001_Y15_NotQuiteLisp_0(Input!));
            Console.WriteLine(AOC_00000001_Y15_NotQuiteLisp_1(Input!));
        }
        #endregion
    }
}
