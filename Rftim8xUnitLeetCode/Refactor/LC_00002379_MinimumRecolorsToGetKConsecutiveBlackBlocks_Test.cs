using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00002379_MinimumRecolorsToGetKConsecutiveBlackBlocks_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002379_MinimumRecolorsToGetKConsecutiveBlackBlocks))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002379_MinimumRecolorsToGetKConsecutiveBlackBlocks))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002379_MinimumRecolorsToGetKConsecutiveBlackBlocks))![1]);

        public static TheoryData<List<string>, int> LC_00002379_MinimumRecolorsToGetKConsecutiveBlackBlocksPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00002379_MinimumRecolorsToGetKConsecutiveBlackBlocksPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00002379_MinimumRecolorsToGetKConsecutiveBlackBlocksPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002379_MinimumRecolorsToGetKConsecutiveBlackBlocks.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002379_MinimumRecolorsToGetKConsecutiveBlackBlocksPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002379_MinimumRecolorsToGetKConsecutiveBlackBlocks.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
