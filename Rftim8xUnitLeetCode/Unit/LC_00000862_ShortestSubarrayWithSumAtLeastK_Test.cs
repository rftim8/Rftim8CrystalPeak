using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00862_ShortestSubarrayWithSumAtLeastK_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00862_ShortestSubarrayWithSumAtLeastK))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00862_ShortestSubarrayWithSumAtLeastK))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00862_ShortestSubarrayWithSumAtLeastK))![1]);

        public static TheoryData<List<string>, int> _00862_ShortestSubarrayWithSumAtLeastKPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00862_ShortestSubarrayWithSumAtLeastKPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00862_ShortestSubarrayWithSumAtLeastKPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00862_ShortestSubarrayWithSumAtLeastK.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00862_ShortestSubarrayWithSumAtLeastKPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00862_ShortestSubarrayWithSumAtLeastK.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
