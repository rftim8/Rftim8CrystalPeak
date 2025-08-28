using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01396_DesignUndergroundSystem_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01396_DesignUndergroundSystem))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01396_DesignUndergroundSystem))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01396_DesignUndergroundSystem))![1]);

        public static TheoryData<List<string>, int> _01396_DesignUndergroundSystemPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01396_DesignUndergroundSystemPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01396_DesignUndergroundSystemPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01396_DesignUndergroundSystem.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01396_DesignUndergroundSystemPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01396_DesignUndergroundSystem.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
