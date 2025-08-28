using Microsoft.Extensions.DependencyInjection;
using Rftim8Convoy.Data.Services.Lifetime;

namespace Rftim8Convoy.Data.Services.Algorithms.Searching.Binary
{
    public interface IBinarySearch : IServiceReportLifetime
    {
        ServiceLifetime IServiceReportLifetime.Lifetime => ServiceLifetime.Singleton;

        public Task BinarySearchTask0();
    }
}
