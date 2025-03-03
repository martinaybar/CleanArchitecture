using MartinAybar.Application.Features.Categories.Commands.CreateCategory;
using MartinAybar.Application.Models;

namespace MartinAybar.Application.Features.Categories.Commands.CreateCateogry;

public class CreateCategoryCommandResponse: BaseResponse
{
    public CreateCategoryCommandResponse(): base()
    {

    }

    public CreateCategoryDto Category { get; set; } = default!;
}