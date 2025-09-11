using Microsoft.Extensions.DependencyInjection;

namespace Rftim8Convoy.Microsoft.Extensions.Hosting.Services.ServiceReportsLifetime.ServiceScoped
{
    public interface IServiceScopedExample : IServiceReportLifetime
    {
        ServiceLifetime IServiceReportLifetime.Lifetime => ServiceLifetime.Scoped;
    }
}
