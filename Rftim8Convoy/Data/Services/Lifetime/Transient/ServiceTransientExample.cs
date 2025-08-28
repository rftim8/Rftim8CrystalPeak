namespace Rftim8Convoy.Data.Services.Lifetime.Transient
{
    public sealed class ServiceTransientExample : IServiceTransientExample
    {
        Guid IServiceReportLifetime.Id { get; } = Guid.NewGuid();
    }
}
