using Microsoft.Extensions.DependencyInjection;

namespace Rftim8Convoy.Microsoft.Extensions.Hosting.Services.ServiceReportsLifetime
{
    public interface IServiceReportLifetime
    {
        Guid Id { get; }

        ServiceLifetime Lifetime { get; }
    }
}
