using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00801_MinimumSwapsToMakeSequencesIncreasing_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00801_MinimumSwapsToMakeSequencesIncreasing))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00801_MinimumSwapsToMakeSequencesIncreasing))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00801_MinimumSwapsToMakeSequencesIncreasing))![1]);

        public static TheoryData<List<string>, int> _00801_MinimumSwapsToMakeSequencesIncreasingPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00801_MinimumSwapsToMakeSequencesIncreasingPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00801_MinimumSwapsToMakeSequencesIncreasingPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00801_MinimumSwapsToMakeSequencesIncreasing.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00801_MinimumSwapsToMakeSequencesIncreasingPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00801_MinimumSwapsToMakeSequencesIncreasing.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
