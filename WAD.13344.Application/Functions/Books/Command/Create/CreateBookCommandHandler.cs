using AutoMapper;
using MediatR;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Interfaces;
using WAD._13344.Domain.Models;

namespace WAD._13344.Application.Functions.Books.Command.Create
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, BookDto>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public CreateBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookDto> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book
            {
                Title = request.Title,
                Description = request.Description,
                AuthorId = request.AuthorId,
                PagesCount = request.PagesCount,
                PublicationDate = request.PublicationDate,
                CategoryId = request.CategoryId
            };

            await _bookRepository.CreateAsync(book);

            return _mapper.Map<BookDto>(book);
        }
    }
}
