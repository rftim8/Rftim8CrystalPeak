using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _03194_MinimumAverageOfSmallestAndLargestElements_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_03194_MinimumAverageOfSmallestAndLargestElements))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03194_MinimumAverageOfSmallestAndLargestElements))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03194_MinimumAverageOfSmallestAndLargestElements))![1]);

        public static TheoryData<List<string>, int> _03194_MinimumAverageOfSmallestAndLargestElementsPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _03194_MinimumAverageOfSmallestAndLargestElementsPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_03194_MinimumAverageOfSmallestAndLargestElementsPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _03194_MinimumAverageOfSmallestAndLargestElements.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_03194_MinimumAverageOfSmallestAndLargestElementsPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _03194_MinimumAverageOfSmallestAndLargestElements.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
