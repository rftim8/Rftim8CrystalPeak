using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8MSTestLeetCode.Unit
{
    [TestClass]
    public sealed class LC_00003691_MaximumTotalSubarrayValueII_Test
    {
        public TestContext TestContext { get; set; } = null!;

        private static readonly List<string>? Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00003691_MaximumTotalSubarrayValueII));
        private static readonly List<int[]>? Nums1 = [];
        private static readonly List<int>? Nums2 = [];
        private static readonly List<long>? Results = [];

        private static void DataCollector_0()
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

        public static IEnumerable<object[]> Solution_0_Data()
        {
            yield return new object[]
            {
                Nums1!, Nums2!, Results!
            };
        }

        [TestMethod]
        [DynamicData(nameof(Solution_0_Data))]
        public void Solution_0(List<int[]> nums1, List<int> nums2, List<long> results)
        {
            DataCollector_0();

            List<long> result = LC_00003691_MaximumTotalSubarrayValueII.Solution_0_Test(Nums1!, Nums2!);
            
            for (int i = 0; i < Nums1!.Count; i++)
            {
                Assert.AreEqual(Results![i], result[i]);
            }
        }
    }
}
