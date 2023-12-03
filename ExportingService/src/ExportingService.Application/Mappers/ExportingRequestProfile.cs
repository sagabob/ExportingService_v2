using AutoMapper;
using ExportingService.Application.Commands;
using ExportingService.Application.Models;

namespace ExportingService.Application.Mappers;

public class ExportingRequestProfile : Profile
{
    public ExportingRequestProfile()
    {
        CreateMap<CreateExportingRequestDto, CreateExportingRequestCommand>();
    }
}