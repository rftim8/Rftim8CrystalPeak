using RftAPI.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00002764_IsArrayAPreorderOfSome‌BinaryTree_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002764_IsArrayAPreorderOfSome‌BinaryTree))!;
        
        public static TheoryData<List<string>> LC_00002764_IsArrayAPreorderOfSome‌BinaryTreePartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00002764_IsArrayAPreorderOfSome‌BinaryTreePartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00002764_IsArrayAPreorderOfSome‌BinaryTreePartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00002764_IsArrayAPreorderOfSome‌BinaryTree.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002764_IsArrayAPreorderOfSome‌BinaryTreePartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00002764_IsArrayAPreorderOfSome‌BinaryTree.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
