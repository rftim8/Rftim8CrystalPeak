using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00002779_MaximumBeautyOfAnArrayAfterApplyingOperation_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00002779_MaximumBeautyOfAnArrayAfterApplyingOperation))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002779_MaximumBeautyOfAnArrayAfterApplyingOperation))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00002779_MaximumBeautyOfAnArrayAfterApplyingOperation))![1]);

        public static TheoryData<List<string>, int> LC_00002779_MaximumBeautyOfAnArrayAfterApplyingOperationPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00002779_MaximumBeautyOfAnArrayAfterApplyingOperationPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00002779_MaximumBeautyOfAnArrayAfterApplyingOperationPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002779_MaximumBeautyOfAnArrayAfterApplyingOperation.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00002779_MaximumBeautyOfAnArrayAfterApplyingOperationPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00002779_MaximumBeautyOfAnArrayAfterApplyingOperation.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
