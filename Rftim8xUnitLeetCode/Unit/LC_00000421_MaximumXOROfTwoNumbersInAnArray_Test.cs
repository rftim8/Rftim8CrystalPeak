using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00421_MaximumXOROfTwoNumbersInAnArray_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00421_MaximumXOROfTwoNumbersInAnArray))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00421_MaximumXOROfTwoNumbersInAnArray))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00421_MaximumXOROfTwoNumbersInAnArray))![1]);

        public static TheoryData<List<string>, int> _00421_MaximumXOROfTwoNumbersInAnArrayPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00421_MaximumXOROfTwoNumbersInAnArrayPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00421_MaximumXOROfTwoNumbersInAnArrayPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00421_MaximumXOROfTwoNumbersInAnArray.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00421_MaximumXOROfTwoNumbersInAnArrayPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00421_MaximumXOROfTwoNumbersInAnArray.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
