using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003053_ClassifyingTrianglesByLengths_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003053_ClassifyingTrianglesByLengths))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00003053_ClassifyingTrianglesByLengths))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00003053_ClassifyingTrianglesByLengths))![1]);

        public static TheoryData<List<string>, int> LC_00003053_ClassifyingTrianglesByLengthsPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00003053_ClassifyingTrianglesByLengthsPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00003053_ClassifyingTrianglesByLengthsPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00003053_ClassifyingTrianglesByLengths.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003053_ClassifyingTrianglesByLengthsPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00003053_ClassifyingTrianglesByLengths.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
