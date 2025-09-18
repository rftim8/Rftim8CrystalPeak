using RftAPI.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003375_MinimumOperationsToMakeArrayValuesEqualToK_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003375_MinimumOperationsToMakeArrayValuesEqualToK))!;
        
        public static TheoryData<List<string>> LC_00003375_MinimumOperationsToMakeArrayValuesEqualToKPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003375_MinimumOperationsToMakeArrayValuesEqualToKPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003375_MinimumOperationsToMakeArrayValuesEqualToKPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003375_MinimumOperationsToMakeArrayValuesEqualToK.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003375_MinimumOperationsToMakeArrayValuesEqualToKPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003375_MinimumOperationsToMakeArrayValuesEqualToK.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
