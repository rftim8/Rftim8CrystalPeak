using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00001338_ReduceArraySizeToTheHalf_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00001338_ReduceArraySizeToTheHalf))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001338_ReduceArraySizeToTheHalf))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001338_ReduceArraySizeToTheHalf))![1]);

        public static TheoryData<List<string>, int> LC_00001338_ReduceArraySizeToTheHalfPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00001338_ReduceArraySizeToTheHalfPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00001338_ReduceArraySizeToTheHalfPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001338_ReduceArraySizeToTheHalf.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00001338_ReduceArraySizeToTheHalfPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001338_ReduceArraySizeToTheHalf.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
