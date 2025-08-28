using Microsoft.Extensions.DependencyInjection;

namespace Rftim8Convoy.Data.Services.Lifetime.Singleton
{
    public interface IServiceSingletonExample : IServiceReportLifetime
    {
        ServiceLifetime IServiceReportLifetime.Lifetime => ServiceLifetime.Singleton;
    }
}
