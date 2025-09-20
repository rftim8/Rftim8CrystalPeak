using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003403_FindTheLexicographicallyLargestStringFromTheBoxI_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003403_FindTheLexicographicallyLargestStringFromTheBoxI))!;
        
        public static TheoryData<List<string>> LC_00003403_FindTheLexicographicallyLargestStringFromTheBoxIPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003403_FindTheLexicographicallyLargestStringFromTheBoxIPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003403_FindTheLexicographicallyLargestStringFromTheBoxIPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003403_FindTheLexicographicallyLargestStringFromTheBoxI.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003403_FindTheLexicographicallyLargestStringFromTheBoxIPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003403_FindTheLexicographicallyLargestStringFromTheBoxI.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
