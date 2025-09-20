using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003584_MaximumProductOfFirstAndLastElementsOfASubsequence_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003584_MaximumProductOfFirstAndLastElementsOfASubsequence))!;
        
        public static TheoryData<List<string>> LC_00003584_MaximumProductOfFirstAndLastElementsOfASubsequencePartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003584_MaximumProductOfFirstAndLastElementsOfASubsequencePartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003584_MaximumProductOfFirstAndLastElementsOfASubsequencePartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003584_MaximumProductOfFirstAndLastElementsOfASubsequence.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003584_MaximumProductOfFirstAndLastElementsOfASubsequencePartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003584_MaximumProductOfFirstAndLastElementsOfASubsequence.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
