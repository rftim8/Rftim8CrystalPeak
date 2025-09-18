using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01409_QueriesOnAPermutationWithKey_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01409_QueriesOnAPermutationWithKey))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01409_QueriesOnAPermutationWithKey))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01409_QueriesOnAPermutationWithKey))![1]);

        public static TheoryData<List<string>, int> _01409_QueriesOnAPermutationWithKeyPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01409_QueriesOnAPermutationWithKeyPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01409_QueriesOnAPermutationWithKeyPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01409_QueriesOnAPermutationWithKey.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01409_QueriesOnAPermutationWithKeyPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01409_QueriesOnAPermutationWithKey.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
