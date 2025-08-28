using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _03244_ShortestDistanceAfterRoadAdditionQueriesII_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_03244_ShortestDistanceAfterRoadAdditionQueriesII))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03244_ShortestDistanceAfterRoadAdditionQueriesII))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03244_ShortestDistanceAfterRoadAdditionQueriesII))![1]);

        public static TheoryData<List<string>, int> _03244_ShortestDistanceAfterRoadAdditionQueriesIIPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _03244_ShortestDistanceAfterRoadAdditionQueriesIIPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_03244_ShortestDistanceAfterRoadAdditionQueriesIIPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _03244_ShortestDistanceAfterRoadAdditionQueriesII.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_03244_ShortestDistanceAfterRoadAdditionQueriesIIPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _03244_ShortestDistanceAfterRoadAdditionQueriesII.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
