using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02558_TakeGiftsFromTheRichestPile_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02558_TakeGiftsFromTheRichestPile))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02558_TakeGiftsFromTheRichestPile))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02558_TakeGiftsFromTheRichestPile))![1]);

        public static TheoryData<List<string>, int> _02558_TakeGiftsFromTheRichestPilePartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02558_TakeGiftsFromTheRichestPilePartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02558_TakeGiftsFromTheRichestPilePartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02558_TakeGiftsFromTheRichestPile.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02558_TakeGiftsFromTheRichestPilePartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02558_TakeGiftsFromTheRichestPile.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
