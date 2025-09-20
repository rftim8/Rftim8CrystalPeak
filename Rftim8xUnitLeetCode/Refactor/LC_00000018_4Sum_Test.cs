using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Xunit.Abstractions;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00000018_4Sum_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00000018_4Sum))!;
        
        public static TheoryData<List<string>> LC_00000018_4SumPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00000018_4SumPartTwo_Input =>
            new()
            {
                { Input }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00000018_4SumPartOne_Input))]
        public void RftPartOne(List<string> a0)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00000018_4Sum.PartOne_Test(a0);
            int expected = 0;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00000018_4SumPartTwo_Input))]
        public void RftPartTwo(List<string> a0)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00000018_4Sum.PartTwo_Test(a0);
            int expected = 0;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
