using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Interfaces;

namespace WAD._13344.Application.Functions.Books.Query.GetAll
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookDto>>
    {
        private readonly IBookRepository _bookRepository;
        public readonly IMapper _mapper;

        public GetAllBooksQueryHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAll().Include(b => b.Author).Include(b => b.Category).ToListAsync();
            return _mapper.Map<List<BookDto>>(books);
        }
    }
}
