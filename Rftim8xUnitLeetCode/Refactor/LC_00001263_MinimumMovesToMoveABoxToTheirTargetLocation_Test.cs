using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00001263_MinimumMovesToMoveABoxToTheirTargetLocation_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00001263_MinimumMovesToMoveABoxToTheirTargetLocation))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001263_MinimumMovesToMoveABoxToTheirTargetLocation))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001263_MinimumMovesToMoveABoxToTheirTargetLocation))![1]);

        public static TheoryData<List<string>, int> LC_00001263_MinimumMovesToMoveABoxToTheirTargetLocationPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00001263_MinimumMovesToMoveABoxToTheirTargetLocationPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00001263_MinimumMovesToMoveABoxToTheirTargetLocationPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001263_MinimumMovesToMoveABoxToTheirTargetLocation.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00001263_MinimumMovesToMoveABoxToTheirTargetLocationPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001263_MinimumMovesToMoveABoxToTheirTargetLocation.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
