using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Xunit.Abstractions;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00000016_3SumClosest_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00000016_3SumClosest))!;
        
        public static TheoryData<List<string>> LC_00000016_3SumClosestPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00000016_3SumClosestPartTwo_Input =>
            new()
            {
                { Input }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00000016_3SumClosestPartOne_Input))]
        public void RftPartOne(List<string> a0)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00000016_3SumClosest.PartOne_Test(a0);
            int expected = 0;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00000016_3SumClosestPartTwo_Input))]
        public void RftPartTwo(List<string> a0)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00000016_3SumClosest.PartTwo_Test(a0);
            int expected = 0;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
