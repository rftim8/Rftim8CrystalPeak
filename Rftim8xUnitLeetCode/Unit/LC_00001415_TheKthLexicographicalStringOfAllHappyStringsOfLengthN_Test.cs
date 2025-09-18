using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01415_TheKthLexicographicalStringOfAllHappyStringsOfLengthN_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01415_TheKthLexicographicalStringOfAllHappyStringsOfLengthN))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01415_TheKthLexicographicalStringOfAllHappyStringsOfLengthN))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01415_TheKthLexicographicalStringOfAllHappyStringsOfLengthN))![1]);

        public static TheoryData<List<string>, int> _01415_TheKthLexicographicalStringOfAllHappyStringsOfLengthNPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01415_TheKthLexicographicalStringOfAllHappyStringsOfLengthNPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01415_TheKthLexicographicalStringOfAllHappyStringsOfLengthNPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01415_TheKthLexicographicalStringOfAllHappyStringsOfLengthN.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01415_TheKthLexicographicalStringOfAllHappyStringsOfLengthNPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01415_TheKthLexicographicalStringOfAllHappyStringsOfLengthN.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
