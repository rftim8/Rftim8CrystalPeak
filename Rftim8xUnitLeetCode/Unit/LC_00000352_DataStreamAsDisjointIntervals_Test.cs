using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00352_DataStreamAsDisjointIntervals_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00352_DataStreamAsDisjointIntervals))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00352_DataStreamAsDisjointIntervals))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00352_DataStreamAsDisjointIntervals))![1]);

        public static TheoryData<List<string>, int> _00352_DataStreamAsDisjointIntervalsPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00352_DataStreamAsDisjointIntervalsPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00352_DataStreamAsDisjointIntervalsPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00352_DataStreamAsDisjointIntervals.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00352_DataStreamAsDisjointIntervalsPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00352_DataStreamAsDisjointIntervals.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
