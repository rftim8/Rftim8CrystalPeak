using Microsoft.Extensions.DependencyInjection;

namespace Rftim8Convoy.Data.Services.Lifetime.Scoped
{
    public interface IServiceScopedExample : IServiceReportLifetime
    {
        ServiceLifetime IServiceReportLifetime.Lifetime => ServiceLifetime.Scoped;
    }
}
