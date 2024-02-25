using AutoMapper;
using MediatR;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Interfaces;

namespace WAD._13344.Application.Functions.Books.Command.Update
{
	internal class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, BookDto>
	{
		private readonly IBookRepository _bookRepository;
		private readonly IMapper _mapper;

		public UpdateBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
		{
			_bookRepository = bookRepository;
			_mapper = mapper;
		}

		public async Task<BookDto> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
		{
			var book = await _bookRepository.GetByIdAsync(request.BookId);

			if (book == null)
			{
				return null;
			}

			book.Title = request.Title;
			book.Description = request.Description;
			book.AuthorId = request.AuthorId;
			book.PagesCount = request.PagesCount;
			book.PublicationDate = request.PublicationDate;
			book.CategoryId = request.CategoryId;

			await _bookRepository.UpdateAsync(book);

			return _mapper.Map<BookDto>(book);
		}
	}
}
