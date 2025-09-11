using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _00602_FriendRequestsIIWhoHasTheMostFriends_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_00602_FriendRequestsIIWhoHasTheMostFriends))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00602_FriendRequestsIIWhoHasTheMostFriends))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_00602_FriendRequestsIIWhoHasTheMostFriends))![1]);

        public static TheoryData<List<string>, int> _00602_FriendRequestsIIWhoHasTheMostFriendsPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _00602_FriendRequestsIIWhoHasTheMostFriendsPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_00602_FriendRequestsIIWhoHasTheMostFriendsPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _00602_FriendRequestsIIWhoHasTheMostFriends.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_00602_FriendRequestsIIWhoHasTheMostFriendsPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _00602_FriendRequestsIIWhoHasTheMostFriends.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
