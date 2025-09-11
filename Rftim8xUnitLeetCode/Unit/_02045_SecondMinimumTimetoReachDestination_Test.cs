using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02045_SecondMinimumTimeToReachDestination_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02045_SecondMinimumTimeToReachDestination))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02045_SecondMinimumTimeToReachDestination))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02045_SecondMinimumTimeToReachDestination))![1]);

        public static TheoryData<List<string>, int> _02045_SecondMinimumTimeToReachDestinationPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02045_SecondMinimumTimeToReachDestinationPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02045_SecondMinimumTimeToReachDestinationPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02045_SecondMinimumTimeToReachDestination.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02045_SecondMinimumTimeToReachDestinationPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02045_SecondMinimumTimeToReachDestination.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
