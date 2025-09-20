using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00001493_LongestSubarrayOf1sAfterDeletingOneElement_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00001493_LongestSubarrayOf1sAfterDeletingOneElement))!;
        
        public static TheoryData<List<string>> LC_00001493_LongestSubarrayOf1sAfterDeletingOneElementPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00001493_LongestSubarrayOf1sAfterDeletingOneElementPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00001493_LongestSubarrayOf1sAfterDeletingOneElementPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00001493_LongestSubarrayOf1sAfterDeletingOneElement.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00001493_LongestSubarrayOf1sAfterDeletingOneElementPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00001493_LongestSubarrayOf1sAfterDeletingOneElement.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
