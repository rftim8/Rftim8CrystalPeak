using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _03230_CustomerPurchasingBehaviorAnalysis_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_03230_CustomerPurchasingBehaviorAnalysis))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03230_CustomerPurchasingBehaviorAnalysis))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_03230_CustomerPurchasingBehaviorAnalysis))![1]);

        public static TheoryData<List<string>, int> _03230_CustomerPurchasingBehaviorAnalysisPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _03230_CustomerPurchasingBehaviorAnalysisPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_03230_CustomerPurchasingBehaviorAnalysisPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _03230_CustomerPurchasingBehaviorAnalysis.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_03230_CustomerPurchasingBehaviorAnalysisPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _03230_CustomerPurchasingBehaviorAnalysis.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
