using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00003284_SumOfConsecutiveSubarrays_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00003284_SumOfConsecutiveSubarrays))!;

        [Fact]
        public void DataCollector()
        {

        }

        public static TheoryData<string[]> Solution_0_Data =>
            new()
            {
                { Input.ToArray() }
            };

        public static TheoryData<string[]> Solution_1_Data =>
            new()
            {
                { Input.ToArray() }
            };

        [Theory]
        [MemberData(nameof(Solution_0_Data))]
        public void Solution_0(string[] a0)
        {
            // Act
            int expected = 0;
            int actual = LC_00003284_SumOfConsecutiveSubarrays.Solution_0_Test([.. a0]);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(Solution_1_Data))]
        public void Solution_1(string[] a0)
        {
            // Act
            int expected = 0;
            int actual = LC_00003284_SumOfConsecutiveSubarrays.Solution_1_Test([.. a0]);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
