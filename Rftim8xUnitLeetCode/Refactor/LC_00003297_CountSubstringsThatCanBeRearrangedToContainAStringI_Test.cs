using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003297_CountSubstringsThatCanBeRearrangedToContainAStringI_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003297_CountSubstringsThatCanBeRearrangedToContainAStringI))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00003297_CountSubstringsThatCanBeRearrangedToContainAStringI))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00003297_CountSubstringsThatCanBeRearrangedToContainAStringI))![1]);

        public static TheoryData<List<string>, int> LC_00003297_CountSubstringsThatCanBeRearrangedToContainAStringIPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00003297_CountSubstringsThatCanBeRearrangedToContainAStringIPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00003297_CountSubstringsThatCanBeRearrangedToContainAStringIPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00003297_CountSubstringsThatCanBeRearrangedToContainAStringI.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003297_CountSubstringsThatCanBeRearrangedToContainAStringIPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00003297_CountSubstringsThatCanBeRearrangedToContainAStringI.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
