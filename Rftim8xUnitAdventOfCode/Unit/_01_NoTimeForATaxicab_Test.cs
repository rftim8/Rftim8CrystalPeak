﻿using Rftim8Convoy.Services.Static.CP.AdventOfCode.Data;
using Rftim8AdventOfCode.Problems;

namespace Rftim8xUnitAdventOfCode.Unit
{
    public class _01_NoTimeForATaxicab_Test
    {
        // Arrange
        private static readonly List<string> Input = RftAdventOfCodeStaticData.Input_Test(problemName: nameof(_01_NoTimeForATaxicab))!;
        private static readonly int ExpectedPartOne = int.Parse(RftAdventOfCodeStaticData.Output_Test(problemName: nameof(_01_NoTimeForATaxicab))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftAdventOfCodeStaticData.Output_Test(problemName: nameof(_01_NoTimeForATaxicab))![1]);

        public static TheoryData<List<string>, int> _01_NoTimeForATaxicabPartOne_Data =>
            new()
            {
                { Input , ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01_NoTimeForATaxicabPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01_NoTimeForATaxicabPartOne_Data))]
        public static void RftPartOne(List<string> input, int expected)
        {
            // Act
            int actual = _01_NoTimeForATaxicab.PartOne_Test(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01_NoTimeForATaxicabPartTwo_Data))]
        public static void RftPartTwo(List<string> input, int expected)
        {
            // Act
            int actual = _01_NoTimeForATaxicab.PartTwo_Test(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
