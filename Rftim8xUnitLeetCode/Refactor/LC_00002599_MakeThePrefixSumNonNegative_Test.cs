using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;
using Xunit.Abstractions;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00002599_MakeThePrefixSumNonNegative_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002599_MakeThePrefixSumNonNegative))!;
        private static readonly int Expected = 0;

        public static TheoryData<List<string>, int> LC_00002599_MakeThePrefixSumNonNegativePartOne_Input =>
            new()
            {
                { Input, Expected }
            };

        public static TheoryData<List<string>, int> LC_00002599_MakeThePrefixSumNonNegativePartTwo_Input =>
            new()
            {
                { Input, Expected }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00002599_MakeThePrefixSumNonNegativePartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00002599_MakeThePrefixSumNonNegative.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002599_MakeThePrefixSumNonNegativePartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00002599_MakeThePrefixSumNonNegative.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
