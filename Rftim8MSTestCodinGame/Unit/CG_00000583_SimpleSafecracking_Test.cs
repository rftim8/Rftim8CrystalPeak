using Rftim8Convoy.Services.Static.CP.CodinGame.Data;
using Rftim8CodinGame.Problems;

namespace Rftim8MSTestCodinGame.Unit
{
    [TestClass]
    public sealed class CG_00000583_SimpleSafecracking_Test
    {
        public TestContext TestContext { get; set; } = null!;

        private static readonly List<string>? Input = RftCodinGameStaticData.Input_Test(testType: true, problemName: nameof(CG_00000583_SimpleSafecracking));

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
            bool result = CG_00000583_SimpleSafecracking.Solution_0_Test(input);

            Assert.AreEqual(true, result);
        }
    }
}
