using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00132_PalindromePartitioningII_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00132_PalindromePartitioningII))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00132_PalindromePartitioningII))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00132_PalindromePartitioningII))![1]);

        public static TheoryData<List<string>, int> _00132_PalindromePartitioningIIPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00132_PalindromePartitioningIIPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00132_PalindromePartitioningIIPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00132_PalindromePartitioningII.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00132_PalindromePartitioningIIPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00132_PalindromePartitioningII.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
