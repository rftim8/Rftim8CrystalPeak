using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00000315_CountOfSmallerNumbersAfterSelf_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00000315_CountOfSmallerNumbersAfterSelf))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00000315_CountOfSmallerNumbersAfterSelf))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00000315_CountOfSmallerNumbersAfterSelf))![1]);

        public static TheoryData<List<string>, int> LC_00000315_CountOfSmallerNumbersAfterSelfPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00000315_CountOfSmallerNumbersAfterSelfPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00000315_CountOfSmallerNumbersAfterSelfPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00000315_CountOfSmallerNumbersAfterSelf.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00000315_CountOfSmallerNumbersAfterSelfPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00000315_CountOfSmallerNumbersAfterSelf.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
