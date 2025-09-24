using Rftim8Convoy.Services.Static.CP.AdventOfCode.Data;
using Rftim8AdventOfCode.Problems;

namespace Rftim8xUnitAdventOfCode.Unit
{
    public class AOC_00000021_Y16_ScrambledLettersAndHash_Test
    {
        // Arrange
        private static readonly List<string> Input = RftAdventOfCodeStaticData.Input_Test(problemName: nameof(AOC_00000021_Y16_ScrambledLettersAndHash))!;
        private static readonly int ExpectedPartOne = int.Parse(RftAdventOfCodeStaticData.Output_Test(problemName: nameof(AOC_00000021_Y16_ScrambledLettersAndHash))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftAdventOfCodeStaticData.Output_Test(problemName: nameof(AOC_00000021_Y16_ScrambledLettersAndHash))![1]);

        public static TheoryData<List<string>, int> AOC_00000021_Y16_ScrambledLettersAndHashPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> AOC_00000021_Y16_ScrambledLettersAndHashPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(AOC_00000021_Y16_ScrambledLettersAndHashPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            //int actual = AOC_00000021_Y16_ScrambledLettersAndHash.PartOne_Test(a0);

            // Assert
            //Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(AOC_00000021_Y16_ScrambledLettersAndHashPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            //int actual = AOC_00000021_Y16_ScrambledLettersAndHash.PartTwo_Test(a0);

            // Assert
            //Assert.Equal(expected, actual);
        }
    }
}
