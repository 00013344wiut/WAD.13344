using MediatR;
using Microsoft.AspNetCore.Mvc;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Functions.Books.Command.Create;
using WAD._13344.Application.Functions.Books.Command.Delete;
using WAD._13344.Application.Functions.Books.Command.Update;
using WAD._13344.Application.Functions.Books.Query.GetAll;
using WAD._13344.Application.Functions.Books.Query.GetById;

namespace WAD._13344.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BooksController : ControllerBase
	{
		private readonly IMediator _mediator;

		public BooksController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<ActionResult<List<BookDto>>> GetBooks()
		{
			var query = new GetAllBooksQuery();
			var books = await _mediator.Send(query);
			return Ok(books);
		}

		[HttpPost]
		public async Task<ActionResult<BookDto>> CreateBook([FromForm] CreateBookCommand command)
		{
			var result = await _mediator.Send(command);
			return Ok(result);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult<BookDto>> UpdateBook(int id, [FromForm] UpdateBookCommand command)
		{
			command.BookId = id;
			var result = await _mediator.Send(command);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<bool>> DeleteBook(int id)
		{
			var command = new DeleteBookCommand { Id = id };
			var result = await _mediator.Send(command);

			if (!result)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<BookDto>> GetBookById(int id)
		{
			var query = new GetBookByIdQuery { Id = id };
			var result = await _mediator.Send(query);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}
	}
}
