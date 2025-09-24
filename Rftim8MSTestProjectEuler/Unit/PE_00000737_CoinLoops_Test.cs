using Rftim8Convoy.Services.Static.CP.ProjectEuler.Data;
using Rftim8ProjectEuler.Problems;

namespace Rftim8MSTestProjectEuler.Unit
{
    [TestClass]
    public sealed class PE_00000737_CoinLoops_Test
    {
        public TestContext TestContext { get; set; } = null!;

        private static readonly List<string>? Input = RftProjectEulerStaticData.Input_Test(testType: true, problemName: nameof(PE_00000737_CoinLoops));

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
            int result = PE_00000737_CoinLoops.Solution_0_Test(input);

            Assert.AreEqual(1, result);
        }
    }
}
