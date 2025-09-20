using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00002136_EarliestPossibleDayOfFullBloom_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002136_EarliestPossibleDayOfFullBloom))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002136_EarliestPossibleDayOfFullBloom))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002136_EarliestPossibleDayOfFullBloom))![1]);

        public static TheoryData<List<string>, int> LC_00002136_EarliestPossibleDayOfFullBloomPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00002136_EarliestPossibleDayOfFullBloomPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00002136_EarliestPossibleDayOfFullBloomPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002136_EarliestPossibleDayOfFullBloom.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002136_EarliestPossibleDayOfFullBloomPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002136_EarliestPossibleDayOfFullBloom.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
