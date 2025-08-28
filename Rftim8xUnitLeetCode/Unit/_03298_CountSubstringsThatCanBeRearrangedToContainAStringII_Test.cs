using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _03298_CountSubstringsThatCanBeRearrangedToContainAStringII_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_03298_CountSubstringsThatCanBeRearrangedToContainAStringII))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03298_CountSubstringsThatCanBeRearrangedToContainAStringII))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03298_CountSubstringsThatCanBeRearrangedToContainAStringII))![1]);

        public static TheoryData<List<string>, int> _03298_CountSubstringsThatCanBeRearrangedToContainAStringIIPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _03298_CountSubstringsThatCanBeRearrangedToContainAStringIIPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_03298_CountSubstringsThatCanBeRearrangedToContainAStringIIPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _03298_CountSubstringsThatCanBeRearrangedToContainAStringII.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_03298_CountSubstringsThatCanBeRearrangedToContainAStringIIPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _03298_CountSubstringsThatCanBeRearrangedToContainAStringII.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
