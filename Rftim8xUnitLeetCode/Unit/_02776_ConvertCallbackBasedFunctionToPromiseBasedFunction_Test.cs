using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _02776_ConvertCallbackBasedFunctionToPromiseBasedFunction_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_02776_ConvertCallbackBasedFunctionToPromiseBasedFunction))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02776_ConvertCallbackBasedFunctionToPromiseBasedFunction))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_02776_ConvertCallbackBasedFunctionToPromiseBasedFunction))![1]);

        public static TheoryData<List<string>, int> _02776_ConvertCallbackBasedFunctionToPromiseBasedFunctionPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _02776_ConvertCallbackBasedFunctionToPromiseBasedFunctionPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_02776_ConvertCallbackBasedFunctionToPromiseBasedFunctionPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _02776_ConvertCallbackBasedFunctionToPromiseBasedFunction.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_02776_ConvertCallbackBasedFunctionToPromiseBasedFunctionPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _02776_ConvertCallbackBasedFunctionToPromiseBasedFunction.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
