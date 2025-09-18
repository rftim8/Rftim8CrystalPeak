using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00001770_MaximumScoreFromPerformingMultiplicationOperations_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00001770_MaximumScoreFromPerformingMultiplicationOperations))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001770_MaximumScoreFromPerformingMultiplicationOperations))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001770_MaximumScoreFromPerformingMultiplicationOperations))![1]);

        public static TheoryData<List<string>, int> LC_00001770_MaximumScoreFromPerformingMultiplicationOperationsPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00001770_MaximumScoreFromPerformingMultiplicationOperationsPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00001770_MaximumScoreFromPerformingMultiplicationOperationsPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001770_MaximumScoreFromPerformingMultiplicationOperations.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00001770_MaximumScoreFromPerformingMultiplicationOperationsPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001770_MaximumScoreFromPerformingMultiplicationOperations.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
