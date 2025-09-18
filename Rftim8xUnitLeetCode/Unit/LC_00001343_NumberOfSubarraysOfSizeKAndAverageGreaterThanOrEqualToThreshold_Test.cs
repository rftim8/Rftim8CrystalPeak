using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01343_NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThreshold_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01343_NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThreshold))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01343_NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThreshold))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01343_NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThreshold))![1]);

        public static TheoryData<List<string>, int> _01343_NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThresholdPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01343_NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThresholdPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01343_NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThresholdPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01343_NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThreshold.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01343_NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThresholdPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01343_NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThreshold.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
