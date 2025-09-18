using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02238_NumberOfTimesADriverWasAPassenger_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02238_NumberOfTimesADriverWasAPassenger))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02238_NumberOfTimesADriverWasAPassenger))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02238_NumberOfTimesADriverWasAPassenger))![1]);

        public static TheoryData<List<string>, int> _02238_NumberOfTimesADriverWasAPassengerPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02238_NumberOfTimesADriverWasAPassengerPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02238_NumberOfTimesADriverWasAPassengerPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02238_NumberOfTimesADriverWasAPassenger.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02238_NumberOfTimesADriverWasAPassengerPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02238_NumberOfTimesADriverWasAPassenger.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
