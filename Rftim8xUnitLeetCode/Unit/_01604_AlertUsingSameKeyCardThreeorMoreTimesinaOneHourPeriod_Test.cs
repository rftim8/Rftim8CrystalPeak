using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01604_AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriod_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01604_AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriod))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01604_AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriod))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01604_AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriod))![1]);

        public static TheoryData<List<string>, int> _01604_AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriodPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01604_AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriodPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01604_AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriodPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01604_AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriod.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01604_AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriodPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01604_AlertUsingSameKeyCardThreeOrMoreTimesInAOneHourPeriod.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
