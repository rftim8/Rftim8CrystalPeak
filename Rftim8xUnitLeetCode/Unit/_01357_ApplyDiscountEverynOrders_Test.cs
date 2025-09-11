using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01357_ApplyDiscountEveryNOrders_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01357_ApplyDiscountEveryNOrders))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01357_ApplyDiscountEveryNOrders))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01357_ApplyDiscountEveryNOrders))![1]);

        public static TheoryData<List<string>, int> _01357_ApplyDiscountEveryNOrdersPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01357_ApplyDiscountEveryNOrdersPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01357_ApplyDiscountEveryNOrdersPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01357_ApplyDiscountEveryNOrders.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01357_ApplyDiscountEveryNOrdersPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01357_ApplyDiscountEveryNOrders.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
