using RftAPI.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003459_LengthOfLongestVShapedDiagonalSegment_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003459_LengthOfLongestVShapedDiagonalSegment))!;
        
        public static TheoryData<List<string>> LC_00003459_LengthOfLongestVShapedDiagonalSegmentPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003459_LengthOfLongestVShapedDiagonalSegmentPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003459_LengthOfLongestVShapedDiagonalSegmentPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003459_LengthOfLongestVShapedDiagonalSegment.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003459_LengthOfLongestVShapedDiagonalSegmentPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003459_LengthOfLongestVShapedDiagonalSegment.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
