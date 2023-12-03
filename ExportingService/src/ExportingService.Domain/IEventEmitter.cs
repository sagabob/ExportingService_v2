namespace ExportingService.Domain;

public interface IEventEmitter<T> where T : IEvent
{
    public IReadOnlyList<T> DomainEvents { get; }
    public void AddEvent(T domainEvent);
    public void RemoveEvent(T domainEvent);
    public void RemoveAllEvents();
}