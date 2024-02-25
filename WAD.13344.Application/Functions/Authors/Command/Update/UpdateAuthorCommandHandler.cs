using AutoMapper;
using MediatR;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Interfaces;
using WAD_13344.Application.Functions.Authors.Command.Update;

namespace WAD._13344.Application.Functions.Authors.Command.Update
{
	internal class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, AuthorDto>
	{
		private readonly IAuthorRepository _authorRepository;
		private readonly IMapper _mapper;

		public UpdateAuthorCommandHandler(IAuthorRepository authorRepository, IMapper mapper)
		{
			_authorRepository = authorRepository;
			_mapper = mapper;
		}

		public async Task<AuthorDto> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
		{
			var author = await _authorRepository.GetByIdAsync(request.AuthorId);

			if (author == null)
			{
				return null;
			}

			author.FirstName = request.FirstName;
			author.LastName = request.LastName;

			await _authorRepository.UpdateAsync(author);

			return _mapper.Map<AuthorDto>(author);
		}
	}
}
