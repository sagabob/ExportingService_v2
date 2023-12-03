﻿using ExportingService.Domain.ValueObjects;

namespace ExportingService.Application.Models;

public class CreateExportingRequestDto
{
    public required ReportUrl[] Urls { get; set; }

    public required string EmailAddress { get; set; }

    public ReportFormat Format { get; set; }

    public required string Title { get; set; }

    public required ReportProduct Product { get; set; }
}