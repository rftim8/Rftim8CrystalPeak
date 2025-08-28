using Microsoft.Extensions.DependencyInjection;

namespace Rftim8Convoy.Data.Services.Lifetime.Transient
{
    public interface IServiceTransientExample : IServiceReportLifetime
    {
        ServiceLifetime IServiceReportLifetime.Lifetime => ServiceLifetime.Transient;
    }
}
