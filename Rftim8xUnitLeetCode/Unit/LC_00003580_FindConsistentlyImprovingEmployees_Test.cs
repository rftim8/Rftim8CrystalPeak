using RftAPI.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003580_FindConsistentlyImprovingEmployees_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003580_FindConsistentlyImprovingEmployees))!;
        
        public static TheoryData<List<string>> LC_00003580_FindConsistentlyImprovingEmployeesPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003580_FindConsistentlyImprovingEmployeesPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003580_FindConsistentlyImprovingEmployeesPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003580_FindConsistentlyImprovingEmployees.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003580_FindConsistentlyImprovingEmployeesPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003580_FindConsistentlyImprovingEmployees.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
