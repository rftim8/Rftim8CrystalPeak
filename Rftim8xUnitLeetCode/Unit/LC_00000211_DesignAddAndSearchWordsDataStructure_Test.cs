using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00211_DesignAddAndSearchWordsDataStructure_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00211_DesignAddAndSearchWordsDataStructure))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00211_DesignAddAndSearchWordsDataStructure))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00211_DesignAddAndSearchWordsDataStructure))![1]);

        public static TheoryData<List<string>, int> _00211_DesignAddAndSearchWordsDataStructurePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00211_DesignAddAndSearchWordsDataStructurePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00211_DesignAddAndSearchWordsDataStructurePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00211_DesignAddAndSearchWordsDataStructure.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00211_DesignAddAndSearchWordsDataStructurePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00211_DesignAddAndSearchWordsDataStructure.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
