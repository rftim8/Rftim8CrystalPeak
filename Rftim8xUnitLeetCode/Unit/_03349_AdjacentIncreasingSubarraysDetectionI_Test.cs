using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _03349_AdjacentIncreasingSubarraysDetectionI_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_03349_AdjacentIncreasingSubarraysDetectionI))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03349_AdjacentIncreasingSubarraysDetectionI))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03349_AdjacentIncreasingSubarraysDetectionI))![1]);

        public static TheoryData<List<string>, int> _03349_AdjacentIncreasingSubarraysDetectionIPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _03349_AdjacentIncreasingSubarraysDetectionIPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_03349_AdjacentIncreasingSubarraysDetectionIPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _03349_AdjacentIncreasingSubarraysDetectionI.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_03349_AdjacentIncreasingSubarraysDetectionIPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _03349_AdjacentIncreasingSubarraysDetectionI.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
