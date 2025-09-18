using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.LeetCode.Data;
using Rftim8Convoy.Services.Static.CP.LeetCode.Data;

namespace Rftim8LeetCode.Problems
{
    public class LC_00000036_ValidSudoku : ILC_00000036_ValidSudoku
    {
        #region Static
        private readonly List<string>? Input;
        private readonly List<char[][]>? boards = [];
        private readonly List<bool>? results = [];

        public LC_00000036_ValidSudoku()
        {
            //Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00000036_ValidSudoku));
            Input = [.. RftResource.LC_00000036_ValidSudoku_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
            DataCollector();
        }

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

        [ParamsSource(nameof(BoardDataSets))]
        public char[][]? Board { get; set; }

        public IEnumerable<char[][]> BoardDataSets() => boards!;

        [Benchmark]
        public bool PartOne() => PartOne0(Board!);

        private static bool PartOne0(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        // Check row
                        for (int k = 0; k < 9; k++)
                        {
                            if (k != j && board[i][k] == board[i][j]) return false;
                        }
                        // Check column
                        for (int k = 0; k < 9; k++)
                        {
                            if (k != i && board[k][j] == board[i][j]) return false;
                        }

                        if (i >= 0 && i < 3 && j >= 0 && j < 3) if (SudokuSubArray(board, board[i][j], 0, 3, 0, 3, i, j) == false) return false;
                        if (i >= 3 && i < 6 && j >= 0 && j < 3) if (SudokuSubArray(board, board[i][j], 3, 6, 0, 3, i, j) == false) return false;
                        if (i >= 6 && i < 9 && j >= 0 && j < 3) if (SudokuSubArray(board, board[i][j], 6, 9, 0, 3, i, j) == false) return false;
                        if (i >= 0 && i < 3 && j >= 3 && j < 6) if (SudokuSubArray(board, board[i][j], 0, 3, 3, 6, i, j) == false) return false;
                        if (i >= 3 && i < 6 && j >= 3 && j < 6) if (SudokuSubArray(board, board[i][j], 3, 6, 3, 6, i, j) == false) return false;
                        if (i >= 6 && i < 9 && j >= 3 && j < 6) if (SudokuSubArray(board, board[i][j], 6, 9, 3, 6, i, j) == false) return false;
                        if (i >= 0 && i < 3 && j >= 6 && j < 9) if (SudokuSubArray(board, board[i][j], 0, 3, 6, 9, i, j) == false) return false;
                        if (i >= 3 && i < 6 && j >= 6 && j < 9) if (SudokuSubArray(board, board[i][j], 3, 6, 6, 9, i, j) == false) return false;
                        if (i >= 6 && i < 9 && j >= 6 && j < 9) if (SudokuSubArray(board, board[i][j], 6, 9, 6, 9, i, j) == false) return false;
                    }
                }
            }

            return true;
        }

        private static bool SudokuSubArray(char[][] board, char x, int n, int m, int o, int p, int q, int r)
        {
            for (int i = n; i < m; i++)
            {
                for (int j = o; j < p; j++)
                {
                    if (q != i && r != j && board[i][j] == x) return false;
                }
            }

            return true;
        }
        #endregion

        #region UnitTest
        public static bool PartOne_Test(char[][] board) => PartOne0(board);
        #endregion

        #region Host
        private readonly IRftLeetCodeHostData? RftLeetCodeHostData;

        public LC_00000036_ValidSudoku(IHost host)
        {
            RftLeetCodeHostData = host.Services.GetRequiredService<IRftLeetCodeHostData>();
            Input = RftLeetCodeHostData.Input_Test(problemName: nameof(LC_00000036_ValidSudoku));
            DataCollector();
        }

        public void PrintSolution()
        {
            for (int i = 0; i < boards!.Count; i++)
            {
                bool actual = PartOne0(boards[i]);
                Console.WriteLine($"Testcase {i + 1}: Expected = {results![i]} => Actual: {actual}");
            }
        }
        #endregion
    }
}
