using ExportingService.Domain.ValueObjects;
using MediatR;

namespace ExportingService.Domain;

public interface IEvent : INotification
{
    public Guid Id { get; }
    public ExportingServiceAction Action { get; }
}