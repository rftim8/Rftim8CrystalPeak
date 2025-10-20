using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Atlas;
using Rftim8Atlas.Models.CP;
using Rftim8Convoy.Services.Host.CP.LeetCode.Data;
using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using System.Numerics;
using System.Text;

namespace Rftim8LeetCode.Problems
{
    public class LC_00003691_MaximumTotalSubarrayValueII : ILC_00003691_MaximumTotalSubarrayValueII
    {
        #region Static
        private readonly List<string>? Input;
        private readonly List<int[]>? Nums1 = [];
        private readonly List<int>? Nums2 = [];
        private readonly List<long>? Results = [];

        public LC_00003691_MaximumTotalSubarrayValueII()
        {
            Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00003691_MaximumTotalSubarrayValueII));
            //Input = [.. RftLCResources.LC_00003691_MaximumTotalSubarrayValueII_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
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
You must select exactly k distinct non-empty subarrays nums[l..r] of nums. 
Subarrays may overlap, but the exact same subarray (same l and r) cannot be chosen more than once.
The value of a subarray nums[l..r] is defined as: max(nums[l..r]) - min(nums[l..r]).
The total value is the sum of the values of all chosen subarrays.
Return the maximum possible total value you can achieve.

Constraints:

1 <= n == nums.length <= 5 * 10​​​​​​​4
0 <= nums[i] <= 109
1 <= k <= min(105, n * (n + 1) / 2)
",
                Solution = solutionName,
                Input = new StringBuilder().AppendLine(Input![0])
                    .AppendLine(Input[1])
                    .AppendLine(string.Join("\n", Nums1!.Select(x => "[" + string.Join(",", x) + "]")))
                    .ToString(),
                Output = " ",
                Difficulty = 2000,
                TestStatus = true,
                Runtime = 0.0,
                Memory = 0.0,
                Algorithms = "Array, Greedy, Segment Tree, Heap(Priority Queue)",
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
                Nums1!.Add([.. Input[i].Replace("[", "").Replace("]", "").Split(",").Select(int.Parse)]);
                Nums2!.Add(int.Parse(Input[i + 1]));
                Results!.Add(long.Parse(Input[i + 2]));
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Benchmark]
        public List<long> Solution_0() => LC_00003691_MaximumTotalSubarrayValueII_0(Nums1!, Nums2!);

        public static int[][] Createsparse(int[] nums, int n, bool mintable)
        {
            int maxlog = 32 - BitOperations.LeadingZeroCount((uint)n);
            int[][] stable = new int[n][];
            for (int i = 0; i < n; i++)
            {
                stable[i] = new int[maxlog + 1];
            }
            for (int i = 0; i < n; i++) stable[i][0] = i;

            for (int j = 1; (1 << j) <= n; j++)
            {
                for (int i = 0; i + (1 << j) <= n; i++)
                {
                    if (mintable)
                    {
                        stable[i][j] = nums[stable[i][j - 1]] < nums[stable[i + (1 << (j - 1))][j - 1]]
                                       ? stable[i][j - 1]
                                       : stable[i + (1 << (j - 1))][j - 1];
                    }
                    else
                    {
                        stable[i][j] = nums[stable[i][j - 1]] > nums[stable[i + (1 << (j - 1))][j - 1]]
                                       ? stable[i][j - 1]
                                       : stable[i + (1 << (j - 1))][j - 1];
                    }
                }
            }
            return stable;
        }

        private static int Rminq(int lo, int hi, int[] nums, int[][] stable)
        {
            int len = hi - lo + 1;
            int k = 31 - BitOperations.LeadingZeroCount((uint)len);

            return Math.Min(nums[stable[lo][k]], nums[stable[hi - (1 << k) + 1][k]]);
        }

        private static int Rmaxq(int lo, int hi, int[] nums, int[][] stable)
        {
            int len = hi - lo + 1;
            int k = 31 - BitOperations.LeadingZeroCount((uint)len);

            return Math.Max(nums[stable[lo][k]], nums[stable[hi - (1 << k) + 1][k]]);
        }

        private static List<long> LC_00003691_MaximumTotalSubarrayValueII_0(List<int[]> nums1, List<int> nums2)
        {
            List<long> results = [];

            for (int i = 0; i < nums1.Count; i++)
            {
                int n = nums1[i].Length;
                int[][] minstable = Createsparse(nums1[i], nums1[i].Length, true);
                int[][] maxstable = Createsparse(nums1[i], nums1[i].Length, false);

                PriorityQueue<int[], int> pq = new(
                    Comparer<int>.Create((a, b) => b.CompareTo(a))
                );

                for (int l = 0; l < n; l++)
                {
                    int maxel = Rmaxq(l, n - 1, nums1[i], maxstable);
                    int minel = Rminq(l, n - 1, nums1[i], minstable);
                    int val = maxel - minel;
                    pq.Enqueue([val, l, n - 1], val);
                }
                long ans = 0;

                for (int j = 0; j < nums2[i]; j++)
                {
                    int[] cur = pq.Dequeue();
                    int val = cur[0], l = cur[1], r = cur[2];
                    ans += val;
                    int newr = r - 1;
                    if (newr >= l)
                    {
                        int newval = Rmaxq(l, newr, nums1[i], maxstable) - Rminq(l, newr, nums1[i], minstable);
                        pq.Enqueue([newval, l, newr], newval);
                    }
                }

                results.Add(ans);
            }

            return results;
        }
        #endregion

        #region UnitTest
        public static List<long> Solution_0_Test(List<int[]> nums1, List<int> nums2) => LC_00003691_MaximumTotalSubarrayValueII_0(nums1, nums2);
        #endregion

        #region Host
        private readonly IRftLeetCodeHostData? RftLeetCodeHostData;

        public LC_00003691_MaximumTotalSubarrayValueII(IHost host)
        {
            RftLeetCodeHostData = host.Services.GetRequiredService<IRftLeetCodeHostData>();
            Input = RftLeetCodeHostData.Input_Test(problemName: nameof(LC_00003691_MaximumTotalSubarrayValueII));
            DataCollector();
        }

        public void PrintSolution()
        {
            List<long> actual = LC_00003691_MaximumTotalSubarrayValueII_0(Nums1!, Nums2!);
            foreach (long item in actual)
            {
                Console.WriteLine(item);
            }

            //SQLLog(nameof(LC_00003691_MaximumTotalSubarrayValueII), nameof(LC_00003691_MaximumTotalSubarrayValueII_0));
        }
        #endregion
    }
}
