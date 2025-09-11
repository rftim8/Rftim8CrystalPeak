using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00828_CountUniqueCharactersOfAllSubstringsOfAGivenString_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00828_CountUniqueCharactersOfAllSubstringsOfAGivenString))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00828_CountUniqueCharactersOfAllSubstringsOfAGivenString))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00828_CountUniqueCharactersOfAllSubstringsOfAGivenString))![1]);

        public static TheoryData<List<string>, int> _00828_CountUniqueCharactersOfAllSubstringsOfAGivenStringPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00828_CountUniqueCharactersOfAllSubstringsOfAGivenStringPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00828_CountUniqueCharactersOfAllSubstringsOfAGivenStringPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00828_CountUniqueCharactersOfAllSubstringsOfAGivenString.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00828_CountUniqueCharactersOfAllSubstringsOfAGivenStringPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00828_CountUniqueCharactersOfAllSubstringsOfAGivenString.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
