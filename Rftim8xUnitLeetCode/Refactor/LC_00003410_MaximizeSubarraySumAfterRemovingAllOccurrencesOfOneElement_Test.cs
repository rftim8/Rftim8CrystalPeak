using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003410_MaximizeSubarraySumAfterRemovingAllOccurrencesOfOneElement_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003410_MaximizeSubarraySumAfterRemovingAllOccurrencesOfOneElement))!;
        
        public static TheoryData<List<string>> LC_00003410_MaximizeSubarraySumAfterRemovingAllOccurrencesOfOneElementPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003410_MaximizeSubarraySumAfterRemovingAllOccurrencesOfOneElementPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003410_MaximizeSubarraySumAfterRemovingAllOccurrencesOfOneElementPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003410_MaximizeSubarraySumAfterRemovingAllOccurrencesOfOneElement.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003410_MaximizeSubarraySumAfterRemovingAllOccurrencesOfOneElementPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003410_MaximizeSubarraySumAfterRemovingAllOccurrencesOfOneElement.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
