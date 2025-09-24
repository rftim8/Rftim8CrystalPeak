using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Json;
using BenchmarkDotNet.Running;
using Rftim8ProjectEuler.Problems;

namespace Rftim8ProjectEuler.Benchmarking
{
    public class RftBenchmark
    {
        public static async Task InitBenchmark()
        {
            ManualConfig config = new();
            config.Add(DefaultConfig.Instance
                .AddExporter(JsonExporter.Brief));

            BenchmarkRunner.Run<PE_00000002_EvenFibonacciNumbers>(config);

            await Task.Run(() => Console.WriteLine("Benchmark Finished Successfully!"));
        }
    }
}
