using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8MSTestLeetCode.Unit
{
    [TestClass]
    public sealed class LC_00003690_SplitAndMergeArrayTransformation_Test
    {
        public TestContext TestContext { get; set; } = null!;

        private static readonly List<string>? Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00003690_SplitAndMergeArrayTransformation));
        private static readonly List<List<int>>? Nums1 = [], Nums2 = [];
        private static readonly List<int>? Results = [];

        private static void DataCollector_0()
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

        public static IEnumerable<object[]> Solution_0_Data()
        {
            yield return new object[]
            {
                Nums1!, Nums2!, Results!
            };
        }

        [TestMethod]
        [DynamicData(nameof(Solution_0_Data))]
        public void Solution_0(List<List<int>> nums1, List<List<int>> nums2, List<int> results)
        {
            DataCollector_0();
            List<int> result = LC_00003690_SplitAndMergeArrayTransformation.Solution_0_Test(Nums1, Nums2);

            for (int i = 0; i < Nums1.Count; i++)
            {
                Assert.AreEqual(Results[i], result[i]);
            }
        }
    }
}
