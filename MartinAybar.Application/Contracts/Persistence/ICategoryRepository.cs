using MartinAybar.Domain.Entities;

namespace MartinAybar.Application.Contracts.Persistence;

public interface ICategoryRepository : IAsyncRepository<Category>
{
    Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
}
