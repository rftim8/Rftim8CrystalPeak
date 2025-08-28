using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02023_NumberOfPairsOfStringsWithConcatenationEqualToTarget_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02023_NumberOfPairsOfStringsWithConcatenationEqualToTarget))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02023_NumberOfPairsOfStringsWithConcatenationEqualToTarget))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02023_NumberOfPairsOfStringsWithConcatenationEqualToTarget))![1]);

        public static TheoryData<List<string>, int> _02023_NumberOfPairsOfStringsWithConcatenationEqualToTargetPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02023_NumberOfPairsOfStringsWithConcatenationEqualToTargetPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02023_NumberOfPairsOfStringsWithConcatenationEqualToTargetPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02023_NumberOfPairsOfStringsWithConcatenationEqualToTarget.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02023_NumberOfPairsOfStringsWithConcatenationEqualToTargetPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02023_NumberOfPairsOfStringsWithConcatenationEqualToTarget.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
