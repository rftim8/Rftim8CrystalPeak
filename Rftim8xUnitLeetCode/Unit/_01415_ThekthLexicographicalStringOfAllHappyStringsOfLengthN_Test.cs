using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01415_ThekthLexicographicalStringOfAllHappyStringsOfLengthN_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01415_ThekthLexicographicalStringOfAllHappyStringsOfLengthN))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01415_ThekthLexicographicalStringOfAllHappyStringsOfLengthN))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01415_ThekthLexicographicalStringOfAllHappyStringsOfLengthN))![1]);

        public static TheoryData<List<string>, int> _01415_ThekthLexicographicalStringOfAllHappyStringsOfLengthNPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01415_ThekthLexicographicalStringOfAllHappyStringsOfLengthNPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01415_ThekthLexicographicalStringOfAllHappyStringsOfLengthNPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01415_ThekthLexicographicalStringOfAllHappyStringsOfLengthN.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01415_ThekthLexicographicalStringOfAllHappyStringsOfLengthNPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01415_ThekthLexicographicalStringOfAllHappyStringsOfLengthN.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
