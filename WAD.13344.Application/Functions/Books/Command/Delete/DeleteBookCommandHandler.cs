using MediatR;
using WAD._13344.Application.Interfaces;
using WAD._13344.Application.Functions.Books.Command.Delete;

namespace WAD_13344.Application.Functions.Books.Command.Delete
{
	public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, bool>
	{
		private readonly IBookRepository _bookRepository;

		public DeleteBookCommandHandler(IBookRepository bookRepository)
		{
			_bookRepository = bookRepository;
		}

		public async Task<bool> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
		{
			var book = await _bookRepository.GetByIdAsync(request.Id);

			if (book == null)
			{
				return false;
			}

			await _bookRepository.DeleteAsync(request.Id);

			return true;
		}
	}
}
