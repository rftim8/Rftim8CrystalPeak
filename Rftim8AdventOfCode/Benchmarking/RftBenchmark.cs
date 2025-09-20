using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Json;
using BenchmarkDotNet.Running;
using Rftim8AdventOfCode.Problems;

namespace Rftim8AdventOfCode.Benchmarking
{
    internal class RftBenchmark
    {
        public static async Task InitBenchmark()
        {
            ManualConfig config = new();
            config.Add(DefaultConfig.Instance.AddExporter(JsonExporter.Brief));

            BenchmarkRunner.Run<AOC_00000001_Y15_NotQuiteLisp>(config);

            await Task.Run(() => Console.WriteLine("Benchmark Finished Successfully!"));
        }
    }
}
