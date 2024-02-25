using AutoMapper;
using MediatR;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Interfaces;
using WAD._13344.Domain.Models;

namespace WAD._13344.Application.Functions.Authors.Command.Create
{
	public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, AuthorDto>
	{
		private readonly IAuthorRepository _authorRepository;
		private readonly IMapper _mapper;

		public CreateAuthorCommandHandler(IAuthorRepository authorRepository, IMapper mapper)
		{
			_authorRepository = authorRepository;
			_mapper = mapper;
		}

		public async Task<AuthorDto> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
		{
			var author = new Author
			{
				FirstName = request.FirstName,
				LastName = request.LastName
			};

			await _authorRepository.CreateAsync(author);

			return _mapper.Map<AuthorDto>(author);
		}
	}
}
