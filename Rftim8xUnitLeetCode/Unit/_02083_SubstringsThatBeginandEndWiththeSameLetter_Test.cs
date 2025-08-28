using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02083_SubstringsThatBeginandEndWiththeSameLetter_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02083_SubstringsThatBeginandEndWiththeSameLetter))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02083_SubstringsThatBeginandEndWiththeSameLetter))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02083_SubstringsThatBeginandEndWiththeSameLetter))![1]);

        public static TheoryData<List<string>, int> _02083_SubstringsThatBeginandEndWiththeSameLetterPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02083_SubstringsThatBeginandEndWiththeSameLetterPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02083_SubstringsThatBeginandEndWiththeSameLetterPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02083_SubstringsThatBeginandEndWiththeSameLetter.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02083_SubstringsThatBeginandEndWiththeSameLetterPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02083_SubstringsThatBeginandEndWiththeSameLetter.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
