using MediatR;
using WAD._13344.Application.DTOs;

namespace WAD._13344.Application.Functions.Categories.Command.Update
{
    public class UpdateCategoryCommand : IRequest<CategoryDto>
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
