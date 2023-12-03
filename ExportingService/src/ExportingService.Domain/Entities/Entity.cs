using Newtonsoft.Json;

namespace ExportingService.Domain.Entities;

public abstract class Entity : IEntity
{
    [JsonProperty] public Guid Id { get; protected init; }
}