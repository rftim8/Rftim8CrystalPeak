﻿using Rftim8Convoy.Services.Static.CP.AdventOfCode.Data;
using Rftim8AdventOfCode.Problems;

namespace Rftim8xUnitAdventOfCode.Unit
{
    public class _25_ClockSignal_Test
    {
        // Arrange
        private static readonly List<string> Input = RftAdventOfCodeStaticData.Input_Test(problemName: nameof(_25_ClockSignal))!;
        private static readonly int ExpectedPartOne = int.Parse(RftAdventOfCodeStaticData.Output_Test(problemName: nameof(_25_ClockSignal))![0]);
        
        public static TheoryData<List<string>, int> _25_ClockSignalPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        [Theory(Skip = "Incomplete")]
        [MemberData(nameof(_25_ClockSignalPartOne_Data))]
        public static void RftPartOne(List<string> input, int expected)
        {
            // Act
            int actual = _25_ClockSignal.PartOne_Test(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
