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

        private static void DataCollector_0(List<string> input)
        {
            int _n = int.Parse(input![0]);
            int _m = int.Parse(input[1]);

            for (int i = 2; i < _n * _m + 2; i += _m)
            {
                Nums!.Add([.. input[i].Replace("[", "").Replace("]", "").Split(",").Select(int.Parse)]);
                Results!.Add(int.Parse(input[i + 1]));
            }
        }

        public static IEnumerable<object[]> Solution_0_Data()
        {
            yield return new object[]
            {
                Input!
            };
        }

        [TestMethod]
        [DynamicData(nameof(Solution_0_Data))]
        public void Solution_0(List<string> input)
        {
            DataCollector_0(input!);

            List<int> actual = LC_00003688_BitwiseOROfEvenNumbersInAnArray.Solution_0_Test(Nums!);

            for (int i = 0; i < Nums!.Count; i++)
            {
                Assert.AreEqual(Results![i], actual[i]);
                TestContext.WriteLine($"Test Case {i + 1}: Passed");
            }
        }
    }
}
