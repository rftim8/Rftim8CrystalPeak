using RftAPI.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00002598_SmallestMissingNonnegativeIntegerAfterOperations_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002598_SmallestMissingNonnegativeIntegerAfterOperations))!;
        
        public static TheoryData<List<string>> LC_00002598_SmallestMissingNonnegativeIntegerAfterOperationsPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00002598_SmallestMissingNonnegativeIntegerAfterOperationsPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00002598_SmallestMissingNonnegativeIntegerAfterOperationsPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00002598_SmallestMissingNonnegativeIntegerAfterOperations.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002598_SmallestMissingNonnegativeIntegerAfterOperationsPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00002598_SmallestMissingNonnegativeIntegerAfterOperations.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
