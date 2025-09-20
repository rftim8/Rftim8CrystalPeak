using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8Convoy.Services.Static.Generic;
using Rftim8LeetCode.Problems;
using Xunit.Abstractions;

namespace Rftim8xUnitLeetCode.Unit
{
    public class LC_00000036_ValidSudoku_Test(ITestOutputHelper testOutputHelper)
    {
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(LC_00000036_ValidSudoku))!;
        private static readonly List<char[][]> Boards = [];
        private static readonly List<bool> Results = [];

        public static TheoryData<List<char[][]>, List<bool>> LC_00000036_ValidSudokuPartOne_Input =>
            new()
            {
                { Boards, Results }
            };

        [Fact]
        public void DataCollector()
        {
            int _n = int.Parse(Input![0]);
            int _m = int.Parse(Input[1]);

            for (int i = 2; i < _n * _m + 2; i += _m)
            {
                char[][] board = new char[9][];
                string test = Input[i];
                bool expected = bool.Parse(Input[i + 1]);
                Results.Add(expected);
                test = test.Replace("\"", "");

                List<string> rows = [.. test.Split("],[")];
                for (int j = 0; j < rows.Count; j++)
                {
                    string s = rows[j].Replace("[", "").Replace("]", "").Replace(",", "");
                    board[j] = s.ToCharArray();

                }
                Boards.Add(board);
            }
        }

        [Theory]
        [MemberData(nameof(LC_00000036_ValidSudokuPartOne_Input))]
        public void RftPartOne(List<char[][]> boards, List<bool> results)
        {
            // Arrange
            DataCollector();

            testOutputHelper.WriteLine(RftConsole.PrintChar2DArrayToString(boards));

            for (int i = 0; i < boards.Count; i++)
            {
                // Act
                bool actual = LC_00000036_ValidSudoku.PartOne_Test(boards[i]);

                // Assert
                Assert.Equal(results[i], actual);
            }
        }
    }
}
