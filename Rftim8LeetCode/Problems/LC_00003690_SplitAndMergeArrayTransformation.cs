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
    public class LC_00003690_SplitAndMergeArrayTransformation : ILC_00003690_SplitAndMergeArrayTransformation
    {
        #region Static
        private readonly List<string>? Input;
        private readonly List<List<int>>? Nums1 = [], Nums2 = [];
        private readonly List<int>? Results = [];

        public LC_00003690_SplitAndMergeArrayTransformation()
        {
            Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00003690_SplitAndMergeArrayTransformation));
            //Input = [.. RftLCResources.LC_00003690_SplitAndMergeArrayTransformation_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
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
                Description = @"You are given two integer arrays nums1 and nums2, each of length n. 
You may perform the following split-and-merge operation on nums1 any number of times:
Choose a subarray nums1[L..R].
Remove that subarray, leaving the prefix nums1[0..L-1] (empty if L = 0) and the suffix nums1[R+1..n-1] (empty if R = n - 1).
Re-insert the removed subarray (in its original order) at any position in the remaining array 
(i.e., between any two elements, at the very start, or at the very end).
Return the minimum number of split-and-merge operations needed to transform nums1 into nums2.
 
Constraints:

2 <= n == nums1.length == nums2.length <= 6
-105 <= nums1[i], nums2[i] <= 105
nums2 is a permutation of nums1.
",
                Solution = solutionName,
                Input = new StringBuilder().AppendLine(Input![0])
                    .AppendLine(Input[1])
                    .AppendLine(string.Join("\n", Nums1!.Select(x => "[" + string.Join(",", x) + "]")))
                    .AppendLine(string.Join("\n", Nums2!.Select(x => "[" + string.Join(",", x) + "]")))
                    .ToString(),
                Output = " ",
                Difficulty = 100,
                TestStatus = true,
                Runtime = 0.0,
                Memory = 0.0,
                Algorithms = "HashTable, BFS",
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
                Nums2!.Add([.. Input[i + 1].Replace("[", "").Replace("]", "").Split(",").Select(int.Parse)]);
                Results!.Add(int.Parse(Input[i + 2]));
            }
        }

        private static readonly Dictionary<string, int> dict = [];

        private static string ConvToStr(List<int> l)
        {
            string res = "";
            foreach (int n in l)
            {
                res += (n + "#");
            }

            return res;
        }

        private static List<List<int>> GeneratedNext(List<int> nums, int step)
        {
            int len = nums.Count;
            List<List<int>> nextL = [];
            for (int l = 0; l < len; l++) // left idx for cutting
            {
                List<int> sample = []; // creat list to track;
                for (int r = l; r < len; r++) // right idx for cutting
                {
                    sample.Add(nums[r]);
                    List<int> restL = [];
                    for (int k = 0; k < len; k++) // fill in the rest of items in original order
                    {
                        if (k < l || k > r)
                            restL.Add(nums[k]);
                    }

                    // Insert cuted List:
                    for (int m = 0; m < restL.Count; m++)
                    {
                        List<int> tmp = [.. restL];
                        tmp.InsertRange(m, sample);
                        string convS = ConvToStr(tmp);

                        if (dict.TryAdd(convS, step))
                        {
                            nextL.Add(tmp);
                        }
                    }
                }
            }

            return nextL;
        }

        /// <summary>
        ///
        /// </summary>
        [Benchmark]
        public List<int> Solution_0() => LC_00003690_SplitAndMergeArrayTransformation_0(Nums1!, Nums2!);

        private static List<int> LC_00003690_SplitAndMergeArrayTransformation_0(List<List<int>> nums1, List<List<int>> nums2)
        {
            List<int> result = [];

            for (int i = 0; i < nums1.Count; i++)
            {
                string target = ConvToStr([.. nums2[i]]);
                string from = ConvToStr([.. nums1[i]]);
                if (from == target)
                {
                    result.Add(0);
                    break;
                }

                PriorityQueue<List<int>, int> pq = new();
                pq.Enqueue([.. nums1[i]], 0);
                HashSet<string> visited = [];

                while (pq.Count > 0 && !dict.ContainsKey(target))
                {
                    pq.TryDequeue(out List<int> cur, out int step);
                    {
                        string curS = ConvToStr(cur);
                        if (visited.Contains(curS))
                            continue;

                        visited.Add(curS);
                        List<List<int>> nextL = GeneratedNext(cur, step + 1);
                        foreach (List<int> next in nextL)
                        {
                            string nextS = ConvToStr(next);

                            if (!visited.Contains(nextS))
                                pq.Enqueue(next, step + 1);
                        }
                    }
                }

                result.Add(dict[target]);
            }

            return result;
        }
        #endregion

        #region UnitTest
        public static List<int> Solution_0_Test(List<List<int>> nums1, List<List<int>> nums2) => LC_00003690_SplitAndMergeArrayTransformation_0(nums1, nums2);
        #endregion

        #region Host
        private readonly IRftLeetCodeHostData? RftLeetCodeHostData;

        public LC_00003690_SplitAndMergeArrayTransformation(IHost host)
        {
            RftLeetCodeHostData = host.Services.GetRequiredService<IRftLeetCodeHostData>();
            Input = RftLeetCodeHostData.Input_Test(problemName: nameof(LC_00003690_SplitAndMergeArrayTransformation));
            DataCollector();
        }

        public void PrintSolution()
        {
            List<int> actual = LC_00003690_SplitAndMergeArrayTransformation_0(Nums1!, Nums2!);
            foreach (int item in actual)
            {
                Console.WriteLine(item);
            }

            SQLLog(nameof(LC_00003690_SplitAndMergeArrayTransformation), nameof(LC_00003690_SplitAndMergeArrayTransformation_0));
        }
        #endregion
    }
}
