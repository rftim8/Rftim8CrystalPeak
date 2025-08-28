using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1))![1]);

        public static TheoryData<List<string>, int> _02654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1PartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1PartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1PartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1PartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
