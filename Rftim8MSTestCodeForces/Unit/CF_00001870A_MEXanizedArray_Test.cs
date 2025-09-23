using Rftim8Convoy.Services.Static.CP.CodeForces.Data;
using Rftim8CodeForces.Problems;

namespace Rftim8MSTestCodeForces.Unit
{
    [TestClass]
    public sealed class CF_00001870A_MEXanizedArray_Test
    {
        public TestContext TestContext { get; set; } = null!;

        private static readonly List<string>? Input = RftCodeForcesStaticData.Input_Test(testType: true, problemName: nameof(CF_00001870A_MEXanizedArray));

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
            bool result = CF_00001870A_MEXanizedArray.Solution_0_Test(input);

            Assert.AreEqual(true, result);
        }
    }
}
