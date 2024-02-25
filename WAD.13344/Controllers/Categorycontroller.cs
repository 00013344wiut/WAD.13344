using MediatR;
using Microsoft.AspNetCore.Mvc;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Functions.Categories.Command.Create;
using WAD._13344.Application.Functions.Categories.Command.Delete;
using WAD._13344.Application.Functions.Categories.Command.Update;
using WAD._13344.Application.Functions.Categories.Query.GetAll;
using WAD._13344.Application.Functions.Categories.Query.GetById;

namespace WAD._13344.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CategoriesController : ControllerBase
	{
		private readonly IMediator _mediator;
		public CategoriesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<ActionResult<List<CategoryDto>>> GetCategories()
		{
			var query = new GetAllCategoriesQuery();
			var categories = await _mediator.Send(query);
			return Ok(categories);
		}

		[HttpPost]
		public async Task<ActionResult<CategoryDto>> CreateCategory([FromForm] CreateCategoryCommand command)
		{
			var result = await _mediator.Send(command);
			return Ok(result);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult<CategoryDto>> UpdateCategory(int id, [FromForm] UpdateCategoryCommand command)
		{
			command.CategoryId = id;
			var result = await _mediator.Send(command);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<bool>> DeleteCategory(int id)
		{
			var command = new DeleteCategoryCommand { Id = id };
			var result = await _mediator.Send(command);

			if (!result)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<CategoryDto>> GetCategoryById(int id)
		{
			var query = new GetCategoryByIdQuery { Id = id };
			var result = await _mediator.Send(query);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}
	}
}
