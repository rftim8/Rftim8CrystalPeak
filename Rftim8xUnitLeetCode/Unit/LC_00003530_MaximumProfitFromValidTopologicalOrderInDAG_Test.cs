using RftAPI.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003530_MaximumProfitFromValidTopologicalOrderInDAG_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003530_MaximumProfitFromValidTopologicalOrderInDAG))!;
        
        public static TheoryData<List<string>> LC_00003530_MaximumProfitFromValidTopologicalOrderInDAGPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003530_MaximumProfitFromValidTopologicalOrderInDAGPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003530_MaximumProfitFromValidTopologicalOrderInDAGPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003530_MaximumProfitFromValidTopologicalOrderInDAG.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003530_MaximumProfitFromValidTopologicalOrderInDAGPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003530_MaximumProfitFromValidTopologicalOrderInDAG.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
