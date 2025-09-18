using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003018_MaximumNumberOfRemovalQueriesThatCanBeProcessedI_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003018_MaximumNumberOfRemovalQueriesThatCanBeProcessedI))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00003018_MaximumNumberOfRemovalQueriesThatCanBeProcessedI))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00003018_MaximumNumberOfRemovalQueriesThatCanBeProcessedI))![1]);

        public static TheoryData<List<string>, int> LC_00003018_MaximumNumberOfRemovalQueriesThatCanBeProcessedIPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00003018_MaximumNumberOfRemovalQueriesThatCanBeProcessedIPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00003018_MaximumNumberOfRemovalQueriesThatCanBeProcessedIPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00003018_MaximumNumberOfRemovalQueriesThatCanBeProcessedI.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003018_MaximumNumberOfRemovalQueriesThatCanBeProcessedIPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00003018_MaximumNumberOfRemovalQueriesThatCanBeProcessedI.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
