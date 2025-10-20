using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8MSTestLeetCode.Unit
{
    [TestClass]
    public sealed class LC_00003689_MaximumTotalSubarrayValueI_Test
    {
        public TestContext TestContext { get; set; } = null!;

        private static readonly List<string>? Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00003689_MaximumTotalSubarrayValueI));
        private static readonly List<List<int>>? Nums = [];
        private static readonly List<int>? Ks = [];
        private static readonly List<long>? Results = [];

        private static void DataCollector_0()
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

        public static IEnumerable<object[]> Solution_0_Data()
        {
            yield return new object[]
            {
                Nums!, Ks!, Results!
            };
        }

        [TestMethod]
        [DynamicData(nameof(Solution_0_Data))]
        public void Solution_0(List<List<int>> nums, List<int> ks, List<long> results)
        {
            DataCollector_0();

            List<long> actual = LC_00003689_MaximumTotalSubarrayValueI.Solution_0_Test(Nums, Ks);

            for (int i = 0; i < Nums.Count; i++)
            {
                Assert.AreEqual(Results[i], actual[i]);
            }
        }
    }
}
