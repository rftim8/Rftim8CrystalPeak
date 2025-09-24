using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8MSTestLeetCode.Unit
{
    [TestClass]
    public sealed class LC_00003688_BitwiseOROfEvenNumbersInAnArray_Test
    {
        public TestContext TestContext { get; set; } = null!;

        private static readonly List<string>? Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00003688_BitwiseOROfEvenNumbersInAnArray));
        private static readonly List<List<int>>? Nums = [];
        private static readonly List<int>? Results = [];

        private static void DataCollector_0()
        {
            int _n = int.Parse(Input![0]);
            int _m = int.Parse(Input[1]);

            for (int i = 2; i < _n * _m + 2; i += _m)
            {
                Nums!.Add([.. Input[i].Replace("[", "").Replace("]", "").Split(",").Select(int.Parse)]);
                Results!.Add(int.Parse(Input[i + 1]));
            }
        }

        public static IEnumerable<object[]> Solution_0_Data()
        {
            yield return new object[]
            {
                Nums!, Results!
            };
        }

        [TestMethod]
        [DynamicData(nameof(Solution_0_Data))]
        public void Solution_0(List<List<int>> nums, List<int> results)
        {
            DataCollector_0();

            List<int> actual = LC_00003688_BitwiseOROfEvenNumbersInAnArray.Solution_0_Test(nums);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(results[i], actual[i]);
            }
        }
    }
}
