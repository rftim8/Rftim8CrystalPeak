using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01521_FindAValueOfAMysteriousFunctionClosestToTarget_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01521_FindAValueOfAMysteriousFunctionClosestToTarget))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01521_FindAValueOfAMysteriousFunctionClosestToTarget))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01521_FindAValueOfAMysteriousFunctionClosestToTarget))![1]);

        public static TheoryData<List<string>, int> _01521_FindAValueOfAMysteriousFunctionClosestToTargetPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01521_FindAValueOfAMysteriousFunctionClosestToTargetPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01521_FindAValueOfAMysteriousFunctionClosestToTargetPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01521_FindAValueOfAMysteriousFunctionClosestToTarget.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01521_FindAValueOfAMysteriousFunctionClosestToTargetPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01521_FindAValueOfAMysteriousFunctionClosestToTarget.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
