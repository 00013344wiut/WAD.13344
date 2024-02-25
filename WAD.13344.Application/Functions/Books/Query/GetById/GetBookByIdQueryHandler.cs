using AutoMapper;
using MediatR;
using WAD._13344.Application.Interfaces;

namespace WAD._13344.Application.Functions.Books.Query.GetById
{
	public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, GetBookByIdResponse>
	{
		private readonly IBookRepository _bookRepository;
		private readonly IMapper _mapper;

		public GetBookByIdQueryHandler(IBookRepository bookRepository, IMapper mapper)
		{
			_bookRepository = bookRepository;
			_mapper = mapper;
		}

		public async Task<GetBookByIdResponse> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
		{
			var book = await _bookRepository.GetByIdAsync(request.Id);

			if (book == null)
			{
				return null;
			}

			return _mapper.Map<GetBookByIdResponse>(book);
		}
	}
}
