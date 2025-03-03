using MartinAybar.Application.Features.Events.Queries.GetEventsExport;

namespace MartinAybar.Application.Contracts.Infrastructure;

public interface ICSVExporter
{
    byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
}
