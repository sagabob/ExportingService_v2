namespace ExportingService.Domain.ValueObjects;

public class ReportUrl
{
    public string? Title { get; set; }
    public required string Url { get; set; }
}