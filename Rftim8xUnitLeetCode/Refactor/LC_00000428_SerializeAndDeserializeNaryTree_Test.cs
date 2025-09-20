using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00000428_SerializeAndDeserializeNaryTree_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00000428_SerializeAndDeserializeNaryTree))!;
        
        public static TheoryData<List<string>> LC_00000428_SerializeAndDeserializeNaryTreePartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00000428_SerializeAndDeserializeNaryTreePartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00000428_SerializeAndDeserializeNaryTreePartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00000428_SerializeAndDeserializeNaryTree.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00000428_SerializeAndDeserializeNaryTreePartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00000428_SerializeAndDeserializeNaryTree.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
