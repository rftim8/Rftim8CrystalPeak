using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _03081_ReplaceQuestionMarksInStringToMinimizeItsValue_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_03081_ReplaceQuestionMarksInStringToMinimizeItsValue))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03081_ReplaceQuestionMarksInStringToMinimizeItsValue))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03081_ReplaceQuestionMarksInStringToMinimizeItsValue))![1]);

        public static TheoryData<List<string>, int> _03081_ReplaceQuestionMarksInStringToMinimizeItsValuePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _03081_ReplaceQuestionMarksInStringToMinimizeItsValuePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_03081_ReplaceQuestionMarksInStringToMinimizeItsValuePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _03081_ReplaceQuestionMarksInStringToMinimizeItsValue.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_03081_ReplaceQuestionMarksInStringToMinimizeItsValuePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _03081_ReplaceQuestionMarksInStringToMinimizeItsValue.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
