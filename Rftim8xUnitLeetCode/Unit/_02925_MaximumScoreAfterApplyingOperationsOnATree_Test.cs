using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02925_MaximumScoreAfterApplyingOperationsOnATree_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02925_MaximumScoreAfterApplyingOperationsOnATree))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02925_MaximumScoreAfterApplyingOperationsOnATree))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02925_MaximumScoreAfterApplyingOperationsOnATree))![1]);

        public static TheoryData<List<string>, int> _02925_MaximumScoreAfterApplyingOperationsOnATreePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02925_MaximumScoreAfterApplyingOperationsOnATreePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02925_MaximumScoreAfterApplyingOperationsOnATreePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02925_MaximumScoreAfterApplyingOperationsOnATree.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02925_MaximumScoreAfterApplyingOperationsOnATreePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02925_MaximumScoreAfterApplyingOperationsOnATree.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
