using CsvHelper;
using MartinAybar.Application.Contracts.Infrastructure;
using MartinAybar.Application.Features.Events.Queries.GetEventsExport;
using System.Globalization;

namespace MartinAybar.Infrastructure;

public class CSVExporterService : ICSVExporterService
{
    public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.GetCultureInfo("en-US"));
            csvWriter.WriteRecords(eventExportDtos);
        }

        return memoryStream.ToArray();
    }
}
