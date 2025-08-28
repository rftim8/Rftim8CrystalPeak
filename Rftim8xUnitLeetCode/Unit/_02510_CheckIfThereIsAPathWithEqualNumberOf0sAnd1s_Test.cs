using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02510_CheckIfThereIsAPathWithEqualNumberOf0sAnd1s_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02510_CheckIfThereIsAPathWithEqualNumberOf0sAnd1s))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02510_CheckIfThereIsAPathWithEqualNumberOf0sAnd1s))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02510_CheckIfThereIsAPathWithEqualNumberOf0sAnd1s))![1]);

        public static TheoryData<List<string>, int> _02510_CheckIfThereIsAPathWithEqualNumberOf0sAnd1sPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02510_CheckIfThereIsAPathWithEqualNumberOf0sAnd1sPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02510_CheckIfThereIsAPathWithEqualNumberOf0sAnd1sPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02510_CheckIfThereIsAPathWithEqualNumberOf0sAnd1s.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02510_CheckIfThereIsAPathWithEqualNumberOf0sAnd1sPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02510_CheckIfThereIsAPathWithEqualNumberOf0sAnd1s.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
