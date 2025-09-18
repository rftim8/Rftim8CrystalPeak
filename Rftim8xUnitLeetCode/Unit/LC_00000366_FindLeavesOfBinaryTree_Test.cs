using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00366_FindLeavesOfBinaryTree_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00366_FindLeavesOfBinaryTree))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00366_FindLeavesOfBinaryTree))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00366_FindLeavesOfBinaryTree))![1]);

        public static TheoryData<List<string>, int> _00366_FindLeavesOfBinaryTreePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00366_FindLeavesOfBinaryTreePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00366_FindLeavesOfBinaryTreePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00366_FindLeavesOfBinaryTree.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00366_FindLeavesOfBinaryTreePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00366_FindLeavesOfBinaryTree.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
