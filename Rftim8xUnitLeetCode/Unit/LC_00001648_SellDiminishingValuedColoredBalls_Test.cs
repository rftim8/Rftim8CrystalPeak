using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00001648_SellDiminishingValuedColoredBalls_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00001648_SellDiminishingValuedColoredBalls))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001648_SellDiminishingValuedColoredBalls))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001648_SellDiminishingValuedColoredBalls))![1]);

        public static TheoryData<List<string>, int> LC_00001648_SellDiminishingValuedColoredBallsPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00001648_SellDiminishingValuedColoredBallsPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00001648_SellDiminishingValuedColoredBallsPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001648_SellDiminishingValuedColoredBalls.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00001648_SellDiminishingValuedColoredBallsPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001648_SellDiminishingValuedColoredBalls.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
