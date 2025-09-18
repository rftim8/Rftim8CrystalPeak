using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00000926_FlipStringToMonotoneIncreasing_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00000926_FlipStringToMonotoneIncreasing))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00000926_FlipStringToMonotoneIncreasing))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00000926_FlipStringToMonotoneIncreasing))![1]);

        public static TheoryData<List<string>, int> LC_00000926_FlipStringToMonotoneIncreasingPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00000926_FlipStringToMonotoneIncreasingPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00000926_FlipStringToMonotoneIncreasingPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00000926_FlipStringToMonotoneIncreasing.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00000926_FlipStringToMonotoneIncreasingPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00000926_FlipStringToMonotoneIncreasing.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
