using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Microsoft.Extensions.Hosting.Services.ServiceReportsLifetime;
using Rftim8Convoy.Data.Services.Algorithms.Searching.Binary;
using Rftim8Convoy.Data.Services.Algorithms;

namespace Rftim8Convoy.Microsoft.Extensions.Hosting
{
    public class HostMain
    {
        public static async Task InitHost(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddTransient<ServiceReportLifetime>();

            builder.Services.AddSingleton<IBinarySearch, BinarySearch>();

            builder.Services.AddTransient<ServiceAlgorithms>();

            IHost host = builder.Build();
            int lifetimeCounter = 0;
            _ = new HostingBase(host, lifetimeCounter);

            await host.StartAsync();
        }
    }
}
