using Rftim8Convoy.Services.Static.CP.AdventOfCode.Data;
using Rftim8AdventOfCode.Problems;

namespace Rftim8xUnitAdventOfCode.Unit
{
    public class AOC_00000007_Y16_InternetProtocolVersion7_Test
    {
        // Arrange
        private static readonly List<string> Input = RftAdventOfCodeStaticData.Input_Test(problemName: nameof(AOC_00000007_Y16_InternetProtocolVersion7))!;
        private static readonly int ExpectedPartOne = int.Parse(RftAdventOfCodeStaticData.Output_Test(problemName: nameof(AOC_00000007_Y16_InternetProtocolVersion7))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftAdventOfCodeStaticData.Output_Test(problemName: nameof(AOC_00000007_Y16_InternetProtocolVersion7))![1]);

        public static TheoryData<List<string>, int> AOC_00000007_Y16_InternetProtocolVersion7PartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> AOC_00000007_Y16_InternetProtocolVersion7PartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(AOC_00000007_Y16_InternetProtocolVersion7PartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = AOC_00000007_Y16_InternetProtocolVersion7.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(AOC_00000007_Y16_InternetProtocolVersion7PartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = AOC_00000007_Y16_InternetProtocolVersion7.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
