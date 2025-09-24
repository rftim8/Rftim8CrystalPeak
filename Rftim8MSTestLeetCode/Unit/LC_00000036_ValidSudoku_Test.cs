using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8MSTestLeetCode.Unit
{
    [TestClass]
    public sealed class LC_00000036_ValidSudoku_Test
    {
        public TestContext TestContext { get; set; } = null!;

        private static readonly List<string>? Input = RftLeetCodeStaticData.Input_Test(testType: true, problemName: nameof(LC_00000036_ValidSudoku)); // Benchmarking;

        private static List<char[][]> BoardsCollector()
        {
            List<char[][]>? boards = [];
            //List<bool>? results = [];
            int _n = int.Parse(Input![0]);
            int _m = int.Parse(Input[1]);

            for (int i = 2; i < _n * _m + 2; i += _m)
            {
                char[][] board = new char[9][];
                string test = Input[i];
                test = test.Replace("\"", "");
                List<string> rows = [.. test.Split("],[")];

                for (int j = 0; j < rows.Count; j++)
                {
                    string s = rows[j].Replace("[", "").Replace("]", "").Replace(",", "");
                    board[j] = s.ToCharArray();
                }
                boards!.Add(board);
            }

            return boards!;
        }

        private static List<bool> ResultsCollector()
        {
            List<bool>? results = [];
            int _n = int.Parse(Input![0]);
            int _m = int.Parse(Input[1]);

            for (int i = 2; i < _n * _m + 2; i += _m)
            {
                results!.Add(bool.Parse(Input[i + 1]));
            }

            return results!;
        }

        public static IEnumerable<object[]> Solution_0_Data()
        {
            yield return new object[]
            {
                BoardsCollector(), ResultsCollector()
            };
        }

        [TestMethod]
        [DynamicData(nameof(Solution_0_Data))]
        public void LC_00000036_Test(List<char[][]> boards, List<bool> results)
        {
            Assert.AreEqual(boards.Count, results.Count, "Mismatch between email and expected result counts.");

            for (int i = 0; i < boards!.Count; i++)
            {
                // bool result = LC_00000036_ValidSudoku.Solution_0_Test(boards[i]);
                TestContext.WriteLine($"Expected = {results[i]} | Actual = {result}");

                Assert.AreEqual(results![i], result, $"Failed at index {i} for email: {boards[i]}");
            }
        }
    }
}
