using RftAPI.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003520_MinimumThresholdForInversionPairsCount_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003520_MinimumThresholdForInversionPairsCount))!;
        
        public static TheoryData<List<string>> LC_00003520_MinimumThresholdForInversionPairsCountPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003520_MinimumThresholdForInversionPairsCountPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003520_MinimumThresholdForInversionPairsCountPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003520_MinimumThresholdForInversionPairsCount.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003520_MinimumThresholdForInversionPairsCountPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003520_MinimumThresholdForInversionPairsCount.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
