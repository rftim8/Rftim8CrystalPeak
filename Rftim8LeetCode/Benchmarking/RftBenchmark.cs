using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Json;
using BenchmarkDotNet.Running;
using Rftim8LeetCode.Problems;

namespace Rftim8LeetCode.Benchmarking
{
    public class RftBenchmark
    {
        public static async Task InitBenchmark()
        {
            ManualConfig config = new();
            config.Add(DefaultConfig.Instance.AddExporter(JsonExporter.Brief));

            BenchmarkRunner.Run<_00001_TwoSum>(config);

            await Task.Run(() => Console.WriteLine("Benchmark Finished Successfully!"));
        }
    }
}
