using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01482_MinimumNumberOfDaysToMakeMBouquets_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01482_MinimumNumberOfDaysToMakeMBouquets))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01482_MinimumNumberOfDaysToMakeMBouquets))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01482_MinimumNumberOfDaysToMakeMBouquets))![1]);

        public static TheoryData<List<string>, int> _01482_MinimumNumberOfDaysToMakeMBouquetsPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01482_MinimumNumberOfDaysToMakeMBouquetsPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01482_MinimumNumberOfDaysToMakeMBouquetsPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01482_MinimumNumberOfDaysToMakeMBouquets.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01482_MinimumNumberOfDaysToMakeMBouquetsPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01482_MinimumNumberOfDaysToMakeMBouquets.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
