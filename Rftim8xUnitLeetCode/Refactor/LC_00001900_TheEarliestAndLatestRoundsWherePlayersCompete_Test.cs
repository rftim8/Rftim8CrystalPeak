using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00001900_TheEarliestAndLatestRoundsWherePlayersCompete_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00001900_TheEarliestAndLatestRoundsWherePlayersCompete))!;
        
        public static TheoryData<List<string>> LC_00001900_TheEarliestAndLatestRoundsWherePlayersCompetePartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00001900_TheEarliestAndLatestRoundsWherePlayersCompetePartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00001900_TheEarliestAndLatestRoundsWherePlayersCompetePartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00001900_TheEarliestAndLatestRoundsWherePlayersCompete.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00001900_TheEarliestAndLatestRoundsWherePlayersCompetePartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00001900_TheEarliestAndLatestRoundsWherePlayersCompete.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
