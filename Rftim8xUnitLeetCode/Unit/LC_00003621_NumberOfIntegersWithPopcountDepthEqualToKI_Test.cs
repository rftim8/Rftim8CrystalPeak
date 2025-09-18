using RftAPI.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003621_NumberOfIntegersWithPopcountDepthEqualToKI_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003621_NumberOfIntegersWithPopcountDepthEqualToKI))!;
        
        public static TheoryData<List<string>> LC_00003621_NumberOfIntegersWithPopcountDepthEqualToKIPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003621_NumberOfIntegersWithPopcountDepthEqualToKIPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003621_NumberOfIntegersWithPopcountDepthEqualToKIPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003621_NumberOfIntegersWithPopcountDepthEqualToKI.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003621_NumberOfIntegersWithPopcountDepthEqualToKIPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003621_NumberOfIntegersWithPopcountDepthEqualToKI.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
