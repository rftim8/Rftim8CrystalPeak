using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003047_FindTheLargestAreaOfSquareInsideTwoRectangles_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003047_FindTheLargestAreaOfSquareInsideTwoRectangles))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00003047_FindTheLargestAreaOfSquareInsideTwoRectangles))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00003047_FindTheLargestAreaOfSquareInsideTwoRectangles))![1]);

        public static TheoryData<List<string>, int> LC_00003047_FindTheLargestAreaOfSquareInsideTwoRectanglesPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00003047_FindTheLargestAreaOfSquareInsideTwoRectanglesPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00003047_FindTheLargestAreaOfSquareInsideTwoRectanglesPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00003047_FindTheLargestAreaOfSquareInsideTwoRectangles.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003047_FindTheLargestAreaOfSquareInsideTwoRectanglesPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00003047_FindTheLargestAreaOfSquareInsideTwoRectangles.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
