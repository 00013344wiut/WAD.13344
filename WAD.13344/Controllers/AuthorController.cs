using MediatR;
using Microsoft.AspNetCore.Mvc;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Functions.Authors.Command.Create;
using WAD._13344.Application.Functions.Authors.Command.Delete;
using WAD._13344.Application.Functions.Authors.Query.GetAll;
using WAD._13344.Application.Functions.Authors.Query.GetById;
using WAD_13344.Application.Functions.Authors.Command.Update;

namespace WAD._13344.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AuthorsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public AuthorsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<ActionResult<List<BookDto>>> GetAuthors()
		{
			var query = new GetAllAuthorsQuery();
			var books = await _mediator.Send(query);
			return Ok(books);
		}

		[HttpPost]
		public async Task<ActionResult<AuthorDto>> CreateAuthor([FromForm] CreateAuthorCommand command)
		{
			var result = await _mediator.Send(command);
			return Ok(result);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult<AuthorDto>> UpdateAuthor(int id, [FromForm] UpdateAuthorCommand command)
		{
			command.AuthorId = id;
			var result = await _mediator.Send(command);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<bool>> DeleteAuthor(int id)
		{
			var command = new DeleteAuthorCommand { Id = id };
			var result = await _mediator.Send(command);

			if (!result)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<AuthorDto>> GetAuthorById(int id)
		{
			var query = new GetAuthorByIdQuery { Id = id };
			var result = await _mediator.Send(query);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}
	}
}
