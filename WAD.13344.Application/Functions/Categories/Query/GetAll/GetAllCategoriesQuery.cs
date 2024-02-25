using MediatR;
using WAD._13344.Application.DTOs;

namespace WAD._13344.Application.Functions.Categories.Query.GetAll
{
    public class GetAllCategoriesQuery : IRequest<List<CategoryDto>>
    {
    }
}
