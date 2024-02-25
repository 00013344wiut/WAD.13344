using AutoMapper;
using MediatR;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Interfaces;

namespace WAD._13344.Application.Functions.Authors.Query.GetById
{
	public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, AuthorDto>
	{
		private readonly IAuthorRepository _authorRepository;
		private readonly IMapper _mapper;

		public GetAuthorByIdQueryHandler(IAuthorRepository authorRepository, IMapper mapper)
		{
			_authorRepository = authorRepository;
			_mapper = mapper;
		}

		public async Task<AuthorDto> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
		{
			var author = await _authorRepository.GetByIdAsync(request.Id);

			if (author == null)
			{
				return null;
			}

			return _mapper.Map<AuthorDto>(author);
		}
	}
}
