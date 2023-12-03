using ExportingService.Application.Commands.Responses;
using MediatR;

namespace ExportingService.Application.Commands.Handlers;

public class
    CreateExportingRequestCommandHandler : IRequestHandler<CreateExportingRequestCommand,
        CreateExportingRequestCommandResponse>
{
    public Task<CreateExportingRequestCommandResponse> Handle(CreateExportingRequestCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}