using Application.Features.Events.Commands.UpdateEvent;
using AutoMapper;
using MartinAybar.Application.Features.Categories.Commands.CreateCategory;
using MartinAybar.Application.Features.Categories.Commands.CreateCateogry;
using MartinAybar.Application.Features.Categories.Queries.GetCategoriesList;
using MartinAybar.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using MartinAybar.Application.Features.Events.Commands.CreateEvent;
using MartinAybar.Application.Features.Events.Queries.GetEventDetail;
using MartinAybar.Application.Features.Events.Queries.GetEventsExport;
using MartinAybar.Application.Features.Events.Queries.GetEventsList;
using MartinAybar.Application.Features.Orders.Queries.GetOrdersForMonth;
using MartinAybar.Domain.Entities;

namespace MartinAybar.Application;

//TODO Replace Automapper
public class AutomapperMappingProfile : Profile
{
    public AutomapperMappingProfile()
    {
        CreateMap<Event, EventListVm>().ReverseMap();
        CreateMap<Event, EventDetailVm>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CategoryListVm>().ReverseMap();
        CreateMap<Category, CategoryEventListVm>().ReverseMap();
        CreateMap<Category, CreateCategoryCommand>().ReverseMap();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
        CreateMap<Event, CategoryEventDto>().ReverseMap();
        CreateMap<Event, EventExportDto>().ReverseMap();

        CreateMap<Event, CreateEventCommand>().ReverseMap();
        CreateMap<Event, UpdateEventCommand>().ReverseMap();
        CreateMap<Event, CategoryEventDto>().ReverseMap();

        CreateMap<Order, OrdersForMonthDto>();
    }
}
