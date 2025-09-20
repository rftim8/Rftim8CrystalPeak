using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00002549_CountDistinctNumbersOnBoard_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002549_CountDistinctNumbersOnBoard))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002549_CountDistinctNumbersOnBoard))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002549_CountDistinctNumbersOnBoard))![1]);

        public static TheoryData<List<string>, int> LC_00002549_CountDistinctNumbersOnBoardPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00002549_CountDistinctNumbersOnBoardPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00002549_CountDistinctNumbersOnBoardPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002549_CountDistinctNumbersOnBoard.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002549_CountDistinctNumbersOnBoardPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002549_CountDistinctNumbersOnBoard.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
