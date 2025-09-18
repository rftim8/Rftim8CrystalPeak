using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01731_TheNumberOfEmployeesWhichReportToEachEmployee_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01731_TheNumberOfEmployeesWhichReportToEachEmployee))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01731_TheNumberOfEmployeesWhichReportToEachEmployee))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01731_TheNumberOfEmployeesWhichReportToEachEmployee))![1]);

        public static TheoryData<List<string>, int> _01731_TheNumberOfEmployeesWhichReportToEachEmployeePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01731_TheNumberOfEmployeesWhichReportToEachEmployeePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01731_TheNumberOfEmployeesWhichReportToEachEmployeePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01731_TheNumberOfEmployeesWhichReportToEachEmployee.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01731_TheNumberOfEmployeesWhichReportToEachEmployeePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01731_TheNumberOfEmployeesWhichReportToEachEmployee.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
