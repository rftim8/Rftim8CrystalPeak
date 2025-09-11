using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02086_MinimumNumberOfFoodBucketsToFeedTheHamsters_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02086_MinimumNumberOfFoodBucketsToFeedTheHamsters))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02086_MinimumNumberOfFoodBucketsToFeedTheHamsters))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02086_MinimumNumberOfFoodBucketsToFeedTheHamsters))![1]);

        public static TheoryData<List<string>, int> _02086_MinimumNumberOfFoodBucketsToFeedTheHamstersPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02086_MinimumNumberOfFoodBucketsToFeedTheHamstersPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02086_MinimumNumberOfFoodBucketsToFeedTheHamstersPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02086_MinimumNumberOfFoodBucketsToFeedTheHamsters.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02086_MinimumNumberOfFoodBucketsToFeedTheHamstersPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02086_MinimumNumberOfFoodBucketsToFeedTheHamsters.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
