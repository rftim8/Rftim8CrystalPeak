using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01239_MaximumLengthOfAConcatenatedStringWithUniqueCharacters_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01239_MaximumLengthOfAConcatenatedStringWithUniqueCharacters))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01239_MaximumLengthOfAConcatenatedStringWithUniqueCharacters))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01239_MaximumLengthOfAConcatenatedStringWithUniqueCharacters))![1]);

        public static TheoryData<List<string>, int> _01239_MaximumLengthOfAConcatenatedStringWithUniqueCharactersPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01239_MaximumLengthOfAConcatenatedStringWithUniqueCharactersPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01239_MaximumLengthOfAConcatenatedStringWithUniqueCharactersPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01239_MaximumLengthOfAConcatenatedStringWithUniqueCharacters.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01239_MaximumLengthOfAConcatenatedStringWithUniqueCharactersPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01239_MaximumLengthOfAConcatenatedStringWithUniqueCharacters.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
