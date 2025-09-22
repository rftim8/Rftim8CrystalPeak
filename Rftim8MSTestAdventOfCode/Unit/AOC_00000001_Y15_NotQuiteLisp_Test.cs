using Rftim8Convoy.Services.Static.CP.AdventOfCode.Data;
using Rftim8AdventOfCode.Problems;

namespace Rftim8MSTestAdventOfCode.Unit
{
    [TestClass]
    public sealed class AOC_00000001_Y15_NotQuiteLisp_Test
    {
        public TestContext TestContext { get; set; } = null!;

        private static readonly List<string>? Input = RftAdventOfCodeStaticData.Input_Test(testType: true, problemName: nameof(AOC_00000001_Y15_NotQuiteLisp));

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
        public void Solution_0(List<string> input)
        {
            int result = AOC_00000001_Y15_NotQuiteLisp.Solution_0_Test(input);

            Assert.AreEqual(280, result);
        }
        private static List<string> DataCollector_1()
        {
            return Input!;
        }

        public static IEnumerable<object[]> Solution_1_Data()
        {
            yield return new object[]
            {
                DataCollector_1()
            };
        }

        [TestMethod]
        [DynamicData(nameof(Solution_0_Data))]
        public void Solution_1(List<string> input)
        {
            int result = AOC_00000001_Y15_NotQuiteLisp.Solution_1_Test(input);

            Assert.AreEqual(1797, result);
        }
    }
}
