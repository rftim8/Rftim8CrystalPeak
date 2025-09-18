using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00535_EncodeAndDecodeTinyURL_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00535_EncodeAndDecodeTinyURL))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00535_EncodeAndDecodeTinyURL))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00535_EncodeAndDecodeTinyURL))![1]);

        public static TheoryData<List<string>, int> _00535_EncodeAndDecodeTinyURLPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00535_EncodeAndDecodeTinyURLPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00535_EncodeAndDecodeTinyURLPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00535_EncodeAndDecodeTinyURL.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00535_EncodeAndDecodeTinyURLPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00535_EncodeAndDecodeTinyURL.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
