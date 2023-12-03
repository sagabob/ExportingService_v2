using ExportingService.Domain.ValueObjects;

namespace ExportingService.Domain.Entities;

public class ExportingRequest : DomainEntity, IAggregateRoot
{
    public ExportingRequest(ReportRequest payLoad)
    {
        PayLoad = payLoad;
    }
    public string? ErrorMessage { get; set; }
    public string? FileName { get; set; }
    public required ReportRequest PayLoad { get; set; }
}