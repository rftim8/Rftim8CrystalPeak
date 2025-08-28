using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02959_NumberOfPossibleSetsOfClosingBranches_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02959_NumberOfPossibleSetsOfClosingBranches))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02959_NumberOfPossibleSetsOfClosingBranches))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02959_NumberOfPossibleSetsOfClosingBranches))![1]);

        public static TheoryData<List<string>, int> _02959_NumberOfPossibleSetsOfClosingBranchesPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02959_NumberOfPossibleSetsOfClosingBranchesPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02959_NumberOfPossibleSetsOfClosingBranchesPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02959_NumberOfPossibleSetsOfClosingBranches.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02959_NumberOfPossibleSetsOfClosingBranchesPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02959_NumberOfPossibleSetsOfClosingBranches.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
