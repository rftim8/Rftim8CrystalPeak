using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00002491_DividePlayersIntoTeamsOfEqualSkill_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002491_DividePlayersIntoTeamsOfEqualSkill))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002491_DividePlayersIntoTeamsOfEqualSkill))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002491_DividePlayersIntoTeamsOfEqualSkill))![1]);

        public static TheoryData<List<string>, int> LC_00002491_DividePlayersIntoTeamsOfEqualSkillPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00002491_DividePlayersIntoTeamsOfEqualSkillPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00002491_DividePlayersIntoTeamsOfEqualSkillPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002491_DividePlayersIntoTeamsOfEqualSkill.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002491_DividePlayersIntoTeamsOfEqualSkillPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002491_DividePlayersIntoTeamsOfEqualSkill.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
