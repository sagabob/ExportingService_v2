using ExportingService.Application.Commands.Responses;
using ExportingService.Domain.ValueObjects;
using MediatR;

namespace ExportingService.Application.Commands;

public class CreateExportingRequestCommand : IRequest<CreateExportingRequestCommandResponse>
{
    public required ReportUrl[] Urls { get; set; }

    public required string EmailAddress { get; set; }

    public ReportFormat Format { get; set; }

    public required string Title { get; set; }

    public required ReportProduct Product { get; set; }
}