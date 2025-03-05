using MartinAybar.Application.Features.Events.Queries.GetEventsExport;

namespace MartinAybar.Application.Contracts.Infrastructure;

public interface ICSVExporterService
{
    byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
}
