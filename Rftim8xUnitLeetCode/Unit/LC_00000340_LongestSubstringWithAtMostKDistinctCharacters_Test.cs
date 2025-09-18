using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00340_LongestSubstringWithAtMostKDistinctCharacters_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00340_LongestSubstringWithAtMostKDistinctCharacters))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00340_LongestSubstringWithAtMostKDistinctCharacters))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00340_LongestSubstringWithAtMostKDistinctCharacters))![1]);

        public static TheoryData<List<string>, int> _00340_LongestSubstringWithAtMostKDistinctCharactersPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00340_LongestSubstringWithAtMostKDistinctCharactersPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00340_LongestSubstringWithAtMostKDistinctCharactersPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00340_LongestSubstringWithAtMostKDistinctCharacters.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00340_LongestSubstringWithAtMostKDistinctCharactersPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00340_LongestSubstringWithAtMostKDistinctCharacters.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
