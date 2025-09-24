using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8MSTestLeetCode.Unit
{
    [TestClass]
    public sealed class LC_00001404_NumberOfStepsToReduceANumberInBinaryRepresentationToOne_Test
    {
        public TestContext TestContext { get; set; } = null!;

        private static readonly List<string>? Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00001404_NumberOfStepsToReduceANumberInBinaryRepresentationToOne));

        private static List<string> DataCollector_0()
        {
            return Input!;
        }

        public static IEnumerable<object[]> Solution_0_Data()
        {
            yield return new object[]
            {
                DataCollector_0()
            };
        }

        [TestMethod]
        [DynamicData(nameof(Solution_0_Data))]
        public void Solution_0(char[][] input)
        {
            // bool result = LC_00001404_NumberOfStepsToReduceANumberInBinaryRepresentationToOne.Solution_0_Test(input);

            //Assert.AreEqual(true, result);
        }
    }
}
