using MediatR;
using WAD._13344.Application.DTOs;

namespace WAD._13344.Application.Functions.Categories.Query.GetById
{
	public class GetCategoryByIdQuery : IRequest<CategoryDto>
	{
		public int Id {  get; set; }
	}
}
