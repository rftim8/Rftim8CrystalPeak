using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003683_EarliestTimeToFinishOneTask_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003683_EarliestTimeToFinishOneTask))!;
        
        public static TheoryData<List<string>> LC_00003683_EarliestTimeToFinishOneTaskPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003683_EarliestTimeToFinishOneTaskPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003683_EarliestTimeToFinishOneTaskPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003683_EarliestTimeToFinishOneTask.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003683_EarliestTimeToFinishOneTaskPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003683_EarliestTimeToFinishOneTask.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
