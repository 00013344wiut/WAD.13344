using MediatR;

namespace WAD._13344.Application.Functions.Books.Command.Delete
{
	public class DeleteBookCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
