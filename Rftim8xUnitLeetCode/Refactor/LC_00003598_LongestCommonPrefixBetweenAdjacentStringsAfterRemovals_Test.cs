using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003598_LongestCommonPrefixBetweenAdjacentStringsAfterRemovals_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003598_LongestCommonPrefixBetweenAdjacentStringsAfterRemovals))!;
        
        public static TheoryData<List<string>> LC_00003598_LongestCommonPrefixBetweenAdjacentStringsAfterRemovalsPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003598_LongestCommonPrefixBetweenAdjacentStringsAfterRemovalsPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003598_LongestCommonPrefixBetweenAdjacentStringsAfterRemovalsPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003598_LongestCommonPrefixBetweenAdjacentStringsAfterRemovals.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003598_LongestCommonPrefixBetweenAdjacentStringsAfterRemovalsPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003598_LongestCommonPrefixBetweenAdjacentStringsAfterRemovals.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
