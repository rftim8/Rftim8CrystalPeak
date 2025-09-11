namespace Rftim8Convoy.Microsoft.Extensions.Hosting.Services.ServiceReportsLifetime.ServiceScoped
{
    public sealed class ServiceScopedExample : IServiceScopedExample
    {
        Guid IServiceReportLifetime.Id { get; } = Guid.NewGuid();
    }
}
