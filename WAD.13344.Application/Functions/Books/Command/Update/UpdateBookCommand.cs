using MediatR;
using WAD._13344.Application.DTOs;

namespace WAD._13344.Application.Functions.Books.Command.Update
{
	public class UpdateBookCommand : IRequest<BookDto>
	{
		public int BookId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int AuthorId { get; set; }
		public int PagesCount { get; set; }
		public DateTime PublicationDate { get; set; }
		public int CategoryId { get; set; }
	}
}
