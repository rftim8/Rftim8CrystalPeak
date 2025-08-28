using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Rftim8Convoy.Dotnet
{
    internal class DotnetHostBase
    {
        public DotnetHostBase(IHost host)
        {
            ServiceDetails(host.Services);
        }

        private static void ServiceDetails(IServiceProvider hostProvider)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;
        }
    }
}
