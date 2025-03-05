using AutoMapper;
using MartinAybar.Application.Contracts.Persistence;
using MartinAybar.Application.Features.Categories.Commands.CreateCateogry;
using MartinAybar.Application.UnitTests.Mocks;
using MartinAybar.Domain.Entities;
using Moq;
using Shouldly;

namespace MartinAybar.Application.UnitTests.Categories.Commands
{
    public class CreateCategoryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;

        public CreateCategoryHandlerTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutomapperMappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidCategory_AddedToCategoriesRepo()
        {
            var handler = new CreateCategoryCommandHandler(_mapper, _mockCategoryRepository.Object);

            await handler.Handle(new CreateCategoryCommand() { Name = "Test" }, CancellationToken.None);

            var allCategories = await _mockCategoryRepository.Object.ListAllAsync();
            allCategories.Count.ShouldBe(5);
        }
    }
}
