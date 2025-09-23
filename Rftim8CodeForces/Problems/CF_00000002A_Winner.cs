using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.CodeForces.Data;
using Rftim8Convoy.Services.Static.CP.CodeForces.Data;

namespace Rftim8CodeForces.Problems
{
    public class CF_00000002A_Winner : ICF_00000002A_Winner
    {
        #region Static
        private readonly List<string>? Input = [];

        public CF_00000002A_Winner()
        {
            Input = RftCodeForcesStaticData.Input_Test(testType: true, problemName: nameof(CF_00000002A_Winner));
            //Input = [.. CF_Resources.CF_00000002A_Winner_Input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries)]; // Benchmarking
            PrintSolution();
        }

        [Benchmark]
        public string Solution_0() => CF_00000002A_Winner_0(Input!);

        private static string CF_00000002A_Winner_0(List<string> input)
        {
            Dictionary<string, int> kvp = [];
            List<(string, int, int)> r = [];
            for (int i = 1; i < input.Count; i++)
            {
                string name = input[i].Split(' ')[0];
                int score = int.Parse(input[i].Split(' ')[1]);

                if (!kvp.ContainsKey(name)) kvp[name] = score;
                else kvp[name] += score;

                r.Add((name, i, kvp[name]));
            }

            int max = kvp.MaxBy(o => o.Value).Value;
            List<KeyValuePair<string, int>> y = [.. kvp.Where(o => o.Value == max)];

            int min = int.MaxValue;
            string namer = string.Empty;
            foreach (KeyValuePair<string, int> item in y)
            {
                foreach ((string, int, int) item1 in r)
                {
                    if (item1.Item1 == item.Key && item1.Item3 >= max)
                    {
                        if (item1.Item2 < min)
                        {
                            min = item1.Item2;
                            namer = item.Key;
                        }
                    }
                }
            }

            return namer;
        }
        #endregion

        #region UnitTest
        public static string Solution_0_Test(List<string> input) => CF_00000002A_Winner_0(input);

        #endregion

        #region Host
        private readonly IRftCodeForcesHostData? RftCodeForcesHostData;

        public CF_00000002A_Winner(IHost host)
        {
            RftCodeForcesHostData = host.Services.GetRequiredService<IRftCodeForcesHostData>();
            Input = RftCodeForcesHostData.Input_Test(problemName: nameof(CF_00000002A_Winner));
        }

        public void PrintSolution()
        {
            Console.WriteLine(CF_00000002A_Winner_0(Input!));
        }
        #endregion
    }
}
