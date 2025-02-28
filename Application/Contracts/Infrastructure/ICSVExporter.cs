using Application.Features.Events.Queries.GetEventsExport;

namespace Application.Contracts.Infrastructure
{
    public interface ICSVExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
