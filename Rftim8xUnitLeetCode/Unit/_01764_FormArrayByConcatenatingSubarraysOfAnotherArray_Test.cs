using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01764_FormArrayByConcatenatingSubarraysOfAnotherArray_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01764_FormArrayByConcatenatingSubarraysOfAnotherArray))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01764_FormArrayByConcatenatingSubarraysOfAnotherArray))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01764_FormArrayByConcatenatingSubarraysOfAnotherArray))![1]);

        public static TheoryData<List<string>, int> _01764_FormArrayByConcatenatingSubarraysOfAnotherArrayPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01764_FormArrayByConcatenatingSubarraysOfAnotherArrayPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01764_FormArrayByConcatenatingSubarraysOfAnotherArrayPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01764_FormArrayByConcatenatingSubarraysOfAnotherArray.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01764_FormArrayByConcatenatingSubarraysOfAnotherArrayPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01764_FormArrayByConcatenatingSubarraysOfAnotherArray.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
