using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02359_FindClosestNodeToGivenTwoNodes_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02359_FindClosestNodeToGivenTwoNodes))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02359_FindClosestNodeToGivenTwoNodes))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02359_FindClosestNodeToGivenTwoNodes))![1]);

        public static TheoryData<List<string>, int> _02359_FindClosestNodeToGivenTwoNodesPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02359_FindClosestNodeToGivenTwoNodesPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02359_FindClosestNodeToGivenTwoNodesPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02359_FindClosestNodeToGivenTwoNodes.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02359_FindClosestNodeToGivenTwoNodesPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02359_FindClosestNodeToGivenTwoNodes.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
