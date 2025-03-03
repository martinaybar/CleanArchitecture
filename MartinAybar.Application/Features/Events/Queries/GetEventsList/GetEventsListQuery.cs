using MediatR;

namespace MartinAybar.Application.Features.Events.Queries.GetEventsList;

public class GetEventsListQuery : IRequest<List<EventListVm>>
{
}
