using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00001354_ConstructTargetArrayWithMultipleSums_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00001354_ConstructTargetArrayWithMultipleSums))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001354_ConstructTargetArrayWithMultipleSums))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001354_ConstructTargetArrayWithMultipleSums))![1]);

        public static TheoryData<List<string>, int> LC_00001354_ConstructTargetArrayWithMultipleSumsPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00001354_ConstructTargetArrayWithMultipleSumsPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00001354_ConstructTargetArrayWithMultipleSumsPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001354_ConstructTargetArrayWithMultipleSums.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00001354_ConstructTargetArrayWithMultipleSumsPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001354_ConstructTargetArrayWithMultipleSums.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
