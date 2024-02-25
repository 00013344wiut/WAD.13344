using MediatR;
using WAD._13344.Application.DTOs;

namespace WAD._13344.Application.Functions.Authors.Query.GetById
{
	public class GetAuthorByIdQuery : IRequest<AuthorDto>
	{
		public int Id {  get; set; }
	}
}
