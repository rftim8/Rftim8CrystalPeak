using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00002968_ApplyOperationsToMaximizeFrequencyScore_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002968_ApplyOperationsToMaximizeFrequencyScore))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002968_ApplyOperationsToMaximizeFrequencyScore))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002968_ApplyOperationsToMaximizeFrequencyScore))![1]);

        public static TheoryData<List<string>, int> LC_00002968_ApplyOperationsToMaximizeFrequencyScorePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00002968_ApplyOperationsToMaximizeFrequencyScorePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00002968_ApplyOperationsToMaximizeFrequencyScorePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002968_ApplyOperationsToMaximizeFrequencyScore.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002968_ApplyOperationsToMaximizeFrequencyScorePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002968_ApplyOperationsToMaximizeFrequencyScore.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
