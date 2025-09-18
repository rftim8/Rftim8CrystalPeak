using RftAPI.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00000050_PowxN_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00000050_PowxN))!;
        
        public static TheoryData<List<string>> LC_00000050_PowxNPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00000050_PowxNPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00000050_PowxNPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00000050_PowxN.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00000050_PowxNPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00000050_PowxN.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
