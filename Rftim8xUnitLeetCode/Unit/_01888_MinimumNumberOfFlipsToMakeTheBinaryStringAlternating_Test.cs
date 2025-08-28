using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01888_MinimumNumberOfFlipsToMakeTheBinaryStringAlternating_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01888_MinimumNumberOfFlipsToMakeTheBinaryStringAlternating))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01888_MinimumNumberOfFlipsToMakeTheBinaryStringAlternating))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01888_MinimumNumberOfFlipsToMakeTheBinaryStringAlternating))![1]);

        public static TheoryData<List<string>, int> _01888_MinimumNumberOfFlipsToMakeTheBinaryStringAlternatingPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01888_MinimumNumberOfFlipsToMakeTheBinaryStringAlternatingPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01888_MinimumNumberOfFlipsToMakeTheBinaryStringAlternatingPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01888_MinimumNumberOfFlipsToMakeTheBinaryStringAlternating.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01888_MinimumNumberOfFlipsToMakeTheBinaryStringAlternatingPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01888_MinimumNumberOfFlipsToMakeTheBinaryStringAlternating.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
