using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using RftCP.LeetCode;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003582_GenerateTagForVideoCaption_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003582_GenerateTagForVideoCaption))!;
        
        public static TheoryData<List<string>> LC_00003582_GenerateTagForVideoCaptionPartOne_Input =>
            new()
            {
                { Input }
            };

        public static TheoryData<List<string>> LC_00003582_GenerateTagForVideoCaptionPartTwo_Input =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Fact]
        public void DataCollector()
        {

        }

        [Theory]
        [MemberData(nameof(LC_00003582_GenerateTagForVideoCaptionPartOne_Input))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003582_GenerateTagForVideoCaption.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003582_GenerateTagForVideoCaptionPartTwo_Input))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Arrange
            DataCollector();

            // Act
            int actual = LC_00003582_GenerateTagForVideoCaption.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
