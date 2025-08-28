using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _03265_CountAlmostEqualPairsI_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_03265_CountAlmostEqualPairsI))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03265_CountAlmostEqualPairsI))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03265_CountAlmostEqualPairsI))![1]);

        public static TheoryData<List<string>, int> _03265_CountAlmostEqualPairsIPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _03265_CountAlmostEqualPairsIPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_03265_CountAlmostEqualPairsIPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _03265_CountAlmostEqualPairsI.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_03265_CountAlmostEqualPairsIPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _03265_CountAlmostEqualPairsI.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
