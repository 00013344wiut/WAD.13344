using MediatR;
using WAD._13344.Application.DTOs;

namespace WAD._13344.Application.Functions.Categories.Command.Create
{
	public class CreateCategoryCommand : IRequest<CategoryDto>
	{
		public string CategoryName { get; set; }
	}
}
