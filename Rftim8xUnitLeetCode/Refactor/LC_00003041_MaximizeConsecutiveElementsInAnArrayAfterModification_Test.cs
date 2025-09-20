using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003041_MaximizeConsecutiveElementsInAnArrayAfterModification_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003041_MaximizeConsecutiveElementsInAnArrayAfterModification))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00003041_MaximizeConsecutiveElementsInAnArrayAfterModification))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00003041_MaximizeConsecutiveElementsInAnArrayAfterModification))![1]);

        public static TheoryData<List<string>, int> LC_00003041_MaximizeConsecutiveElementsInAnArrayAfterModificationPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00003041_MaximizeConsecutiveElementsInAnArrayAfterModificationPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00003041_MaximizeConsecutiveElementsInAnArrayAfterModificationPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00003041_MaximizeConsecutiveElementsInAnArrayAfterModification.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00003041_MaximizeConsecutiveElementsInAnArrayAfterModificationPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00003041_MaximizeConsecutiveElementsInAnArrayAfterModification.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
