using MartinAybar.Application.Contracts;
using MartinAybar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;

namespace MartinAybar.Persistence.IntegrationTest;

public class CleanArchitectureDbContextTests
{
    private readonly CleanArchitectureDbContext _globoTicketDbContext;
    private readonly Mock<ILoggedInUserService> _loggedInUserServiceMock;
    private readonly string _loggedInUserId;

    public CleanArchitectureDbContextTests()
    {
        var dbContextOptions = new DbContextOptionsBuilder<CleanArchitectureDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

        _loggedInUserId = "00000000-0000-0000-0000-000000000000";
        _loggedInUserServiceMock = new Mock<ILoggedInUserService>();
        _loggedInUserServiceMock.Setup(m => m.UserId).Returns(_loggedInUserId);

        _globoTicketDbContext = new CleanArchitectureDbContext(dbContextOptions, _loggedInUserServiceMock.Object);
    }

    [Fact]
    public async void Save_SetCreatedByProperty()
    {
        var ev = new Event() {EventId = Guid.NewGuid(), Name = "Test event" };

        _globoTicketDbContext.Events.Add(ev);
        await _globoTicketDbContext.SaveChangesAsync();

        ev.CreatedBy.ShouldBe(_loggedInUserId);
    }
}
