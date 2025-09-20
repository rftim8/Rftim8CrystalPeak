using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00000869_ReorderedPowerOfTwo_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00000869_ReorderedPowerOfTwo))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00000869_ReorderedPowerOfTwo))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00000869_ReorderedPowerOfTwo))![1]);

        public static TheoryData<List<string>, int> _00000869_ReorderedPowerOfTwoPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00000869_ReorderedPowerOfTwoPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00000869_ReorderedPowerOfTwoPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00000869_ReorderedPowerOfTwo.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00000869_ReorderedPowerOfTwoPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00000869_ReorderedPowerOfTwo.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
