using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00865_SmallestSubtreeWithAllTheDeepestNodes_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00865_SmallestSubtreeWithAllTheDeepestNodes))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00865_SmallestSubtreeWithAllTheDeepestNodes))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00865_SmallestSubtreeWithAllTheDeepestNodes))![1]);

        public static TheoryData<List<string>, int> _00865_SmallestSubtreeWithAllTheDeepestNodesPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00865_SmallestSubtreeWithAllTheDeepestNodesPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00865_SmallestSubtreeWithAllTheDeepestNodesPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00865_SmallestSubtreeWithAllTheDeepestNodes.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00865_SmallestSubtreeWithAllTheDeepestNodesPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00865_SmallestSubtreeWithAllTheDeepestNodes.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
