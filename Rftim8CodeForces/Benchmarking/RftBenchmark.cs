using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Json;
using BenchmarkDotNet.Running;
using Rftim8CodeForces.Problems;

namespace Rftim8CodeForces.Benchmarking
{
    internal class RftBenchmark
    {
        public static async Task InitBenchmark()
        {
            ManualConfig config = new();
            config.Add(DefaultConfig.Instance.AddExporter(JsonExporter.Brief));

            BenchmarkRunner.Run<CF_00000002A_Winner>(config);

            await Task.Run(() => Console.WriteLine("Benchmark Finished Successfully!"));
        }
    }
}
