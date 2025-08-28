namespace Rftim8Convoy.Data.Services.Lifetime.Scoped
{
    public sealed class ServiceScopedExample : IServiceScopedExample
    {
        Guid IServiceReportLifetime.Id { get; } = Guid.NewGuid();
    }
}
