using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00000036_ValidSudoku_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00000036_ValidSudoku))!;
        private static readonly List<char[][]> boards = [];
        private static readonly List<bool> results = [];

        [Fact]
        public void DataCollector()
        {
            int _n = int.Parse(Input![0]);
            int _m = int.Parse(Input[1]);

            for (int i = 2; i < _n * _m + 2; i += _m)
            {
                char[][] board = new char[9][];
                string test = Input[i];
                results!.Add(bool.Parse(Input[i + 1]));
                test = test.Replace("\"", "");

                List<string> rows = [.. test.Split("],[")];
                for (int j = 0; j < rows.Count; j++)
                {
                    string s = rows[j].Replace("[", "").Replace("]", "").Replace(",", "");
                    board[j] = s.ToCharArray();
                }
                boards!.Add(board);
            }
        }

        public static TheoryData<List<char[][]>, List<bool>> Solution_0_Data =>
            new()
            {
                { boards, results }
            };

        [Theory]
        [MemberData(nameof(Solution_0_Data))]
        public void Solution_0(List<char[][]> a0, List<bool> expected)
        {
            a0 = [.. boards];

            for (int i = 0; i < a0.Count; i++)
            {
                // Act
                bool actual = LC_00000036_ValidSudoku.Solution_0_Test(a0[i]);

                // Assert
                Assert.Equal(expected[i], actual);
            }
        }
    }
}
