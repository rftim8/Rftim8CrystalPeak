using BenchmarkDotNet.Attributes;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Atlas;
using Rftim8Atlas.Models.CP;
using Rftim8Convoy.Services.Host.CP.LeetCode.Data;
using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using System.Text;

namespace Rftim8LeetCode.Problems
{
    public class LC_00003688_BitwiseOROfEvenNumbersInAnArray : ILC_00003688_BitwiseOROfEvenNumbersInAnArray
    {
        #region Static
        private readonly List<string>? Input = [];
        private readonly List<List<int>>? Nums = [];
        private readonly List<int>? Results = [];

        private void SQLLog(string fileName, string solutionName)
        {
            CPModel cPModel = new()
            {
                Id = 1,
                Competition = "Weekly Contest 468",
                Timestamp = DateTime.Now,
                Rank = 0,
                Rating = 0,
                Problem = fileName,
                Description = @"You are given an integer array nums.
Return the bitwise OR of all even numbers in the array.
If there are no even numbers in nums, return 0.

Constraints:

1 <= nums.length <= 100
1 <= nums[i] <= 100",
                Solution = solutionName,
                Input = new StringBuilder().AppendLine(Input![0])
                    .AppendLine(Input[1])
                    .AppendLine(string.Join("\n", Nums!.Select(x => "[" + string.Join(",", x) + "]")))
                    .ToString(),
                Output = " ",
                Difficulty = 100,
                TestStatus = true,
                Runtime = 0.0,
                Memory = 0.0,
                Algorithms = "Bit Manipulation, Array",
                FilePath = Directory.GetCurrentDirectory()
            };

            _ = new GenericCPTSQL(cPModel);
        }
        /// <summary>
        /// You are given an integer array nums.
        /// Return the bitwise OR of all even numbers in the array.
        /// If there are no even numbers in nums, return 0.
        /// 
        /// Constraints:
        /// 
        /// 1 <= nums.length <= 100
        /// 1 <= nums[i] <= 100
        /// </summary>
        public LC_00003688_BitwiseOROfEvenNumbersInAnArray()
        {
            Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00003688_BitwiseOROfEvenNumbersInAnArray));
            //Input = [.. RftLCResources.LC_00003688_BitwiseOROfEvenNumbersInAnArray_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
            DataCollector();
            PrintSolution();
        }

        public void DataCollector()
        {
            int _n = int.Parse(Input![0]);
            int _m = int.Parse(Input[1]);

            for (int i = 2; i < _n * _m + 2; i += _m)
            {
                Nums!.Add([.. Input[i].Replace("[", "").Replace("]", "").Split(",").Select(int.Parse)]);
                Results!.Add(int.Parse(Input[i + 1]));
            }
        }
        [Benchmark]
        public List<int> Solution_0() => LC_00003688_BitwiseOROfEvenNumbersInAnArray_0(Nums!);

        private static List<int> LC_00003688_BitwiseOROfEvenNumbersInAnArray_0(List<List<int>> input)
        {
            List<int> results = [];

            foreach (List<int> item in input)
            {
                int result = 0;

                foreach (int item1 in item)
                {
                    if (item1 % 2 == 0)
                    {
                        result |= item1;
                    }
                }

                results.Add(result);
            }

            return results;
        }
        #endregion

        #region UnitTest
        public static List<int> Solution_0_Test(List<List<int>> data) => LC_00003688_BitwiseOROfEvenNumbersInAnArray_0(data);
        #endregion

        #region Host
        private readonly IRftLeetCodeHostData? RftLeetCodeHostData;

        public LC_00003688_BitwiseOROfEvenNumbersInAnArray(IHost host)
        {
            RftLeetCodeHostData = host.Services.GetRequiredService<IRftLeetCodeHostData>();
            Input = RftLeetCodeHostData.Input_Test(problemName: nameof(LC_00003688_BitwiseOROfEvenNumbersInAnArray));
            DataCollector();
        }

        public void PrintSolution()
        {
            List<int> actual = LC_00003688_BitwiseOROfEvenNumbersInAnArray_0(Nums!);
            foreach (int item in actual)
            {
                Console.WriteLine(item);
            }

            //SQLLog(nameof(LC_00003688_BitwiseOROfEvenNumbersInAnArray), nameof(LC_00003688_BitwiseOROfEvenNumbersInAnArray_0));
        }
        #endregion
    }
}

