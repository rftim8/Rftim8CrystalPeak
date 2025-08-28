using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01983_WidestPairOfIndicesWithEqualRangeSum_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01983_WidestPairOfIndicesWithEqualRangeSum))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01983_WidestPairOfIndicesWithEqualRangeSum))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01983_WidestPairOfIndicesWithEqualRangeSum))![1]);

        public static TheoryData<List<string>, int> _01983_WidestPairOfIndicesWithEqualRangeSumPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01983_WidestPairOfIndicesWithEqualRangeSumPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01983_WidestPairOfIndicesWithEqualRangeSumPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01983_WidestPairOfIndicesWithEqualRangeSum.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01983_WidestPairOfIndicesWithEqualRangeSumPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01983_WidestPairOfIndicesWithEqualRangeSum.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
