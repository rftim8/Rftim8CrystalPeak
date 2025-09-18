using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00538_ConvertBSTToGreaterTree_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00538_ConvertBSTToGreaterTree))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00538_ConvertBSTToGreaterTree))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00538_ConvertBSTToGreaterTree))![1]);

        public static TheoryData<List<string>, int> _00538_ConvertBSTToGreaterTreePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00538_ConvertBSTToGreaterTreePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00538_ConvertBSTToGreaterTreePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00538_ConvertBSTToGreaterTree.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00538_ConvertBSTToGreaterTreePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00538_ConvertBSTToGreaterTree.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
