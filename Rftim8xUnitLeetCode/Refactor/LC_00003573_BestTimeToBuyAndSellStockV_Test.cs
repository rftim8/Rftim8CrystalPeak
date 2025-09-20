using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003573_BestTimeToBuyAndSellStockV_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003573_BestTimeToBuyAndSellStockV))!;
        
        public static TheoryData<List<string>> LC_00003573_BestTimeToBuyAndSellStockVPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003573_BestTimeToBuyAndSellStockVPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003573_BestTimeToBuyAndSellStockVPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003573_BestTimeToBuyAndSellStockV.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003573_BestTimeToBuyAndSellStockVPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003573_BestTimeToBuyAndSellStockV.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
