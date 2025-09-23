using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Json;
using BenchmarkDotNet.Running;
using Rftim8CodinGame.Problems;

namespace Rftim8CodinGame.Benchmarking
{
    internal class RftBenchmark
    {
        public static async Task InitBenchmark()
        {
            ManualConfig config = new();
            config.Add(DefaultConfig.Instance.AddExporter(JsonExporter.Brief));

            BenchmarkRunner.Run<CG_00000001_1000000000DWORLD>(config);

            await Task.Run(() => Console.WriteLine("Benchmark Finished Successfully!"));
        }
    }
}
