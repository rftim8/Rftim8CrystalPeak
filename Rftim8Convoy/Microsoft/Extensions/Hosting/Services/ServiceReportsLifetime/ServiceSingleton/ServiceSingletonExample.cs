namespace Rftim8Convoy.Microsoft.Extensions.Hosting.Services.ServiceReportsLifetime.ServiceSingleton
{
    public sealed class ServiceSingletonExample : IServiceSingletonExample
    {
        Guid IServiceReportLifetime.Id { get; } = Guid.NewGuid();
    }
}
