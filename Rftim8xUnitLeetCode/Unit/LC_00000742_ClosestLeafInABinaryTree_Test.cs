using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00742_ClosestLeafInABinaryTree_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00742_ClosestLeafInABinaryTree))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00742_ClosestLeafInABinaryTree))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00742_ClosestLeafInABinaryTree))![1]);

        public static TheoryData<List<string>, int> _00742_ClosestLeafInABinaryTreePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00742_ClosestLeafInABinaryTreePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00742_ClosestLeafInABinaryTreePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00742_ClosestLeafInABinaryTree.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00742_ClosestLeafInABinaryTreePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00742_ClosestLeafInABinaryTree.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
