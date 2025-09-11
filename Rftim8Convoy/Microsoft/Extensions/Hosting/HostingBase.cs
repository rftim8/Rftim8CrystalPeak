using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Microsoft.Extensions.Hosting.Services.ServiceReportsLifetime;

namespace Rftim8Convoy.Microsoft.Extensions.Hosting
{
    internal class HostingBase : IHostingBase
    {
        public HostingBase(IHost host, int lifetimeCounter)
        {
            ServiceDetails(host.Services, $"Lifetime {lifetimeCounter}");
        }

        private static void ServiceDetails(IServiceProvider hostProvider, string lifetime)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            ServiceReportLifetime logger = serviceProvider.GetRequiredService<ServiceReportLifetime>();
            logger.ServiceReportLifetimeDetails($"{lifetime}: Call 0 to provider.GetRequiredService<ServiceLifetimeReporter>()");

            //ServiceAlgorithms serviceAlgorithms = serviceProvider.GetRequiredService<ServiceAlgorithms>();
            //serviceAlgorithms.ServiceAlgorithmsExecute();

            logger = serviceProvider.GetRequiredService<ServiceReportLifetime>();
            logger.ServiceReportLifetimeDetails($"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeReporter>()");

            Console.WriteLine();
        }
    }
}
