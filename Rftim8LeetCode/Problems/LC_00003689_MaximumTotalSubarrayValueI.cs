using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Atlas;
using Rftim8Atlas.Models.CP;
using Rftim8Convoy.Services.Host.CP.LeetCode.Data;
using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using System.Text;

namespace Rftim8LeetCode.Problems
{
    public class LC_00003689_MaximumTotalSubarrayValueI : ILC_00003689_MaximumTotalSubarrayValueI
    {
        #region Static
        private readonly List<string>? Input;
        private readonly List<List<int>>? Nums = [];
        private readonly List<int>? Ks = [];
        private readonly List<long>? Results = [];

        public LC_00003689_MaximumTotalSubarrayValueI()
        {
            Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00003689_MaximumTotalSubarrayValueI));
            //Input = [.. RftLCResources.LC_00003689_MaximumTotalSubarrayValueI_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
            DataCollector();
            PrintSolution();
        }
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
                Description = @"You are given an integer array nums of length n and an integer k.
You need to choose exactly k non-empty subarrays nums[l..r] of nums.
Subarrays may overlap, and the exact same subarray(same l and r) can be chosen more than once.
The value of a subarray nums[l..r] is defined as: max(nums[l..r]) - min(nums[l..r]).
The total value is the sum of the values of all chosen subarrays.
Return the maximum possible total value you can achieve.

Constraints:

1 <= n == nums.length <= 5 * 10​​​​​​​4
0 <= nums[i] <= 109
1 <= k <= 105",
                Solution = solutionName,
                Input = new StringBuilder().AppendLine(Input![0])
                    .AppendLine(Input[1])
                    .AppendLine(string.Join("\n", Nums!.Select(x => "[" + string.Join(",", x) + "]")))
                    .ToString(),
                Output = " ",
                Difficulty = 1000,
                TestStatus = true,
                Runtime = 0.0,
                Memory = 0.0,
                Algorithms = "Bit Manipulation, Array",
                FilePath = Directory.GetCurrentDirectory()
            };

            _ = new GenericCPTSQL(cPModel);
        }

        public void DataCollector()
        {
            int _n = int.Parse(Input![0]);
            int _m = int.Parse(Input[1]);

            for (int i = 2; i < _n * _m + 2; i += _m)
            {
                Nums!.Add([.. Input[i].Replace("[", "").Replace("]", "").Split(",").Select(int.Parse)]);
                Ks!.Add(int.Parse(Input[i + 1]));
                Results!.Add(long.Parse(Input[i + 2]));
            }
        }

        /// <summary>
        /// You are given an integer array nums of length n and an integer k.
        /// You need to choose exactly k non-empty subarrays nums[l..r] of nums.
        /// Subarrays may overlap, and the exact same subarray(same l and r) can be chosen more than once.
        /// The value of a subarray nums[l..r] is defined as: max(nums[l..r]) - min(nums[l..r]).
        /// The total value is the sum of the values of all chosen subarrays.
        /// Return the maximum possible total value you can achieve.
        /// 
        /// Constraints:
        /// 
        /// 1 <= n == nums.length <= 5 * 10​​​​​​​4
        /// 0 <= nums[i] <= 109
        /// 1 <= k <= 105
        /// </summary>
        [Benchmark]
        public List<long> Solution_0() => LC_00003689_MaximumTotalSubarrayValueI_0(Nums!, Ks!);

        private static List<long> LC_00003689_MaximumTotalSubarrayValueI_0(List<List<int>> nums, List<int> ks)
        {
            List<long> result = [];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i].Count == 1)
                    result.Add(0);

                long min = nums[i][0];
                long max = nums[i][0];
                foreach (int item in nums[i])
                {
                    if (min > item) min = item;
                    if (max < item) max = item;
                }

                result.Add((max - min) * ks[i]);
            }

            return result;
        }
        #endregion

        #region UnitTest
        public static List<long> Solution_0_Test(List<List<int>> data, List<int> ks) => LC_00003689_MaximumTotalSubarrayValueI_0(data, ks);
        #endregion

        #region Host
        private readonly IRftLeetCodeHostData? RftLeetCodeHostData;

        public LC_00003689_MaximumTotalSubarrayValueI(IHost host)
        {
            RftLeetCodeHostData = host.Services.GetRequiredService<IRftLeetCodeHostData>();
            Input = RftLeetCodeHostData.Input_Test(problemName: nameof(LC_00003689_MaximumTotalSubarrayValueI));
            DataCollector();
        }

        public void PrintSolution()
        {
            foreach (long item in LC_00003689_MaximumTotalSubarrayValueI_0(Nums!, Ks!))
            {
                Console.WriteLine(item);
            }

            //SQLLog(nameof(LC_00003689_MaximumTotalSubarrayValueI), nameof(LC_00003689_MaximumTotalSubarrayValueI_0));
        }
        #endregion
    }
}
