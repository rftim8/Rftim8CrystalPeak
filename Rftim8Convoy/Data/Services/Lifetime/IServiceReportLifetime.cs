using Microsoft.Extensions.DependencyInjection;

namespace Rftim8Convoy.Data.Services.Lifetime
{
    public interface IServiceReportLifetime
    {
        Guid Id { get; }

        ServiceLifetime Lifetime { get; }
    }
}
