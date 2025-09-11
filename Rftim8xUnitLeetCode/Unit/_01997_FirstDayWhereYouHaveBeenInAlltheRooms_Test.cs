using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01997_FirstDayWhereYouHaveBeenInAllTheRooms_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01997_FirstDayWhereYouHaveBeenInAllTheRooms))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01997_FirstDayWhereYouHaveBeenInAllTheRooms))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01997_FirstDayWhereYouHaveBeenInAllTheRooms))![1]);

        public static TheoryData<List<string>, int> _01997_FirstDayWhereYouHaveBeenInAllTheRoomsPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01997_FirstDayWhereYouHaveBeenInAllTheRoomsPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01997_FirstDayWhereYouHaveBeenInAllTheRoomsPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01997_FirstDayWhereYouHaveBeenInAllTheRooms.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01997_FirstDayWhereYouHaveBeenInAllTheRoomsPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01997_FirstDayWhereYouHaveBeenInAllTheRooms.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
