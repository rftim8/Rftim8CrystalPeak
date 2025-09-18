using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00002273_FindResultantArrayAfterRemovingAnagrams_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002273_FindResultantArrayAfterRemovingAnagrams))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002273_FindResultantArrayAfterRemovingAnagrams))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002273_FindResultantArrayAfterRemovingAnagrams))![1]);

        public static TheoryData<List<string>, int> LC_00002273_FindResultantArrayAfterRemovingAnagramsPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00002273_FindResultantArrayAfterRemovingAnagramsPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00002273_FindResultantArrayAfterRemovingAnagramsPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002273_FindResultantArrayAfterRemovingAnagrams.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002273_FindResultantArrayAfterRemovingAnagramsPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002273_FindResultantArrayAfterRemovingAnagrams.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
