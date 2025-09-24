using Rftim8Convoy.Services.Static.CP.AdventOfCode.Data;
using Rftim8AdventOfCode.Problems;

namespace Rftim8xUnitAdventOfCode.Unit
{
    public class AOC_00000011_Y16_RadioisotopeThermoelectricGenerators_Test
    {
        // Arrange
        private static readonly List<string> Input = RftAdventOfCodeStaticData.Input_Test(problemName: nameof(AOC_00000011_Y16_RadioisotopeThermoelectricGenerators))!;
        private static readonly int ExpectedPartOne = int.Parse(RftAdventOfCodeStaticData.Output_Test(problemName: nameof(AOC_00000011_Y16_RadioisotopeThermoelectricGenerators))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftAdventOfCodeStaticData.Output_Test(problemName: nameof(AOC_00000011_Y16_RadioisotopeThermoelectricGenerators))![1]);

        public static TheoryData<List<string>, int> AOC_00000011_Y16_RadioisotopeThermoelectricGeneratorsPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> AOC_00000011_Y16_RadioisotopeThermoelectricGeneratorsPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(AOC_00000011_Y16_RadioisotopeThermoelectricGeneratorsPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            //int actual = AOC_00000011_Y16_RadioisotopeThermoelectricGenerators.PartOne_Test(a0);

            // Assert
            //Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(AOC_00000011_Y16_RadioisotopeThermoelectricGeneratorsPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            //int actual = AOC_00000011_Y16_RadioisotopeThermoelectricGenerators.PartTwo_Test(a0);

            // Assert
            //Assert.Equal(expected, actual);
        }
    }
}
