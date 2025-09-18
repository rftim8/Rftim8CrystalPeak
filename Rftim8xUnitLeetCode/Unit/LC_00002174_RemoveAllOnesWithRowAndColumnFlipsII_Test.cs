using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02174_RemoveAllOnesWithRowAndColumnFlipsII_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02174_RemoveAllOnesWithRowAndColumnFlipsII))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02174_RemoveAllOnesWithRowAndColumnFlipsII))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02174_RemoveAllOnesWithRowAndColumnFlipsII))![1]);

        public static TheoryData<List<string>, int> _02174_RemoveAllOnesWithRowAndColumnFlipsIIPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02174_RemoveAllOnesWithRowAndColumnFlipsIIPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02174_RemoveAllOnesWithRowAndColumnFlipsIIPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02174_RemoveAllOnesWithRowAndColumnFlipsII.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02174_RemoveAllOnesWithRowAndColumnFlipsIIPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02174_RemoveAllOnesWithRowAndColumnFlipsII.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
