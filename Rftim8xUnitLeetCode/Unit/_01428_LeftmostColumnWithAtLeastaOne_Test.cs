using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01428_LeftmostColumnWithAtLeastAOne_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01428_LeftmostColumnWithAtLeastAOne))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01428_LeftmostColumnWithAtLeastAOne))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01428_LeftmostColumnWithAtLeastAOne))![1]);

        public static TheoryData<List<string>, int> _01428_LeftmostColumnWithAtLeastAOnePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01428_LeftmostColumnWithAtLeastAOnePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01428_LeftmostColumnWithAtLeastAOnePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01428_LeftmostColumnWithAtLeastAOne.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01428_LeftmostColumnWithAtLeastAOnePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01428_LeftmostColumnWithAtLeastAOne.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
