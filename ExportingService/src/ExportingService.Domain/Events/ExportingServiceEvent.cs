using ExportingService.Domain.Entities;
using ExportingService.Domain.ValueObjects;
using Newtonsoft.Json;

namespace ExportingService.Domain.Events;

public abstract class ExportingServiceEvent : Entity, IEvent
{
    protected ExportingServiceEvent(Guid id, Guid exportingRequestId, ExportingServiceAction action)
    {
        Id = id;
        ExportingRequestId = exportingRequestId;
        Action = action;
        CreatedAt = DateTimeOffset.UtcNow;
    }

    public Guid ExportingRequestId { get; }
    [JsonProperty] private DateTimeOffset CreatedAt { get; }
    public ExportingServiceAction Action { get; }
}