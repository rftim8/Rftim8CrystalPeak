using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00001558_MinimumNumbersOfFunctionCallsToMakeTargetArray_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00001558_MinimumNumbersOfFunctionCallsToMakeTargetArray))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001558_MinimumNumbersOfFunctionCallsToMakeTargetArray))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(LC_00001558_MinimumNumbersOfFunctionCallsToMakeTargetArray))![1]);

        public static TheoryData<List<string>, int> LC_00001558_MinimumNumbersOfFunctionCallsToMakeTargetArrayPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> LC_00001558_MinimumNumbersOfFunctionCallsToMakeTargetArrayPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(LC_00001558_MinimumNumbersOfFunctionCallsToMakeTargetArrayPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001558_MinimumNumbersOfFunctionCallsToMakeTargetArray.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(LC_00001558_MinimumNumbersOfFunctionCallsToMakeTargetArrayPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = LC_00001558_MinimumNumbersOfFunctionCallsToMakeTargetArray.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
