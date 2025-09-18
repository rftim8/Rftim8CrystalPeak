using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00001495_FriendlyMoviesStreamedLastMonth_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00001495_FriendlyMoviesStreamedLastMonth))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001495_FriendlyMoviesStreamedLastMonth))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001495_FriendlyMoviesStreamedLastMonth))![1]);

        public static TheoryData<List<string>, int> LC_00001495_FriendlyMoviesStreamedLastMonthPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00001495_FriendlyMoviesStreamedLastMonthPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00001495_FriendlyMoviesStreamedLastMonthPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001495_FriendlyMoviesStreamedLastMonth.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00001495_FriendlyMoviesStreamedLastMonthPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001495_FriendlyMoviesStreamedLastMonth.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
