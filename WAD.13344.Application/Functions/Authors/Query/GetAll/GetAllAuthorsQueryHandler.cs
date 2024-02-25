using AutoMapper;
using MediatR;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Interfaces;

namespace WAD._13344.Application.Functions.Authors.Query.GetAll
{
    public class GetAllAuthorsQueryHandler : IRequestHandler<GetAllAuthorsQuery, List<AuthorDto>>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public GetAllAuthorsQueryHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }
        public async Task<List<AuthorDto>> Handle(GetAllAuthorsQuery request, CancellationToken cancellationToken)
        {
            var authors = await _authorRepository.GetAllAsync();
            return _mapper.Map<List<AuthorDto>>(authors);
        }
    }
}
