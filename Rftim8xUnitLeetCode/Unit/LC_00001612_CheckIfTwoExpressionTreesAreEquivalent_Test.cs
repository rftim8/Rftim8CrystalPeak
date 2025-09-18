using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01612_CheckIfTwoExpressionTreesAreEquivalent_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01612_CheckIfTwoExpressionTreesAreEquivalent))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01612_CheckIfTwoExpressionTreesAreEquivalent))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01612_CheckIfTwoExpressionTreesAreEquivalent))![1]);

        public static TheoryData<List<string>, int> _01612_CheckIfTwoExpressionTreesAreEquivalentPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01612_CheckIfTwoExpressionTreesAreEquivalentPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01612_CheckIfTwoExpressionTreesAreEquivalentPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01612_CheckIfTwoExpressionTreesAreEquivalent.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01612_CheckIfTwoExpressionTreesAreEquivalentPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01612_CheckIfTwoExpressionTreesAreEquivalent.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
