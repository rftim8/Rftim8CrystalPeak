using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _03291_MinimumNumberOfValidStringsToFormTargetI_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_03291_MinimumNumberOfValidStringsToFormTargetI))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03291_MinimumNumberOfValidStringsToFormTargetI))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03291_MinimumNumberOfValidStringsToFormTargetI))![1]);

        public static TheoryData<List<string>, int> _03291_MinimumNumberOfValidStringsToFormTargetIPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _03291_MinimumNumberOfValidStringsToFormTargetIPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_03291_MinimumNumberOfValidStringsToFormTargetIPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _03291_MinimumNumberOfValidStringsToFormTargetI.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_03291_MinimumNumberOfValidStringsToFormTargetIPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _03291_MinimumNumberOfValidStringsToFormTargetI.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
