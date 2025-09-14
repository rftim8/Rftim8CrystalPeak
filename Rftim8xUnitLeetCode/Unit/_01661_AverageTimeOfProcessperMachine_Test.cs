using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01661_AverageTimeOfProcessPerMachine_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01661_AverageTimeOfProcessPerMachine))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01661_AverageTimeOfProcessPerMachine))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01661_AverageTimeOfProcessPerMachine))![1]);

        public static TheoryData<List<string>, int> _01661_AverageTimeOfProcessPerMachinePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01661_AverageTimeOfProcessPerMachinePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01661_AverageTimeOfProcessPerMachinePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01661_AverageTimeOfProcessPerMachine.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01661_AverageTimeOfProcessPerMachinePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01661_AverageTimeOfProcessPerMachine.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
