using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02459_SortArraByMovingItemsToEmptySpace_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002459_SortArrayByMovingItemsToEmptySpace))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002459_SortArrayByMovingItemsToEmptySpace))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002459_SortArrayByMovingItemsToEmptySpace))![1]);

        public static TheoryData<List<string>, int> LC_00002459_SortArrayByMovingItemsToEmptySpacePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00002459_SortArrayByMovingItemsToEmptySpacePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00002459_SortArrayByMovingItemsToEmptySpacePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002459_SortArrayByMovingItemsToEmptySpace.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002459_SortArrayByMovingItemsToEmptySpacePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002459_SortArrayByMovingItemsToEmptySpace.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
