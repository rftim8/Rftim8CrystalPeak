using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;
using Xunit.Abstractions;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00002829_DetermineTheMinimumSumOfAKAvoidingArray_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002829_DetermineTheMinimumSumOfAKAvoidingArray))!;
        private static readonly int Expected = 0;

        public static TheoryData<List<string>, int> LC_00002829_DetermineTheMinimumSumOfAKAvoidingArrayPartOne_Input =>
            new()
            {
                { Input, Expected }
            };

        public static TheoryData<List<string>, int> LC_00002829_DetermineTheMinimumSumOfAKAvoidingArrayPartTwo_Input =>
            new()
            {
                { Input, Expected }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00002829_DetermineTheMinimumSumOfAKAvoidingArrayPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00002829_DetermineTheMinimumSumOfAKAvoidingArray.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002829_DetermineTheMinimumSumOfAKAvoidingArrayPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00002829_DetermineTheMinimumSumOfAKAvoidingArray.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
