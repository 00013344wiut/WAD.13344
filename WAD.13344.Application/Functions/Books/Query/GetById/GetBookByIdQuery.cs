using MediatR;

namespace WAD._13344.Application.Functions.Books.Query.GetById
{
	public class GetBookByIdQuery : IRequest<GetBookByIdResponse>
	{
		public int Id { get; set; }
	}
}
