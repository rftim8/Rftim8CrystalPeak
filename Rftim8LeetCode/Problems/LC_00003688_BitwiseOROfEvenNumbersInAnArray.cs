using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.LeetCode.Data;
using Rftim8Convoy.Services.Static.CP.LeetCode.Data;

namespace Rftim8LeetCode.Problems
{
    public class LC_00003688_BitwiseOROfEvenNumbersInAnArray : ILC_00003688_BitwiseOROfEvenNumbersInAnArray
    {
        #region Static
        private readonly List<string>? Input = [];
        private readonly List<List<int>>? Nums = [];
        private readonly List<int>? Results = [];

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
        }
        #endregion
    }
}
