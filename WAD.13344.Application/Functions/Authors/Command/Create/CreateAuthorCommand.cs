using MediatR;
using WAD._13344.Application.DTOs;

namespace WAD._13344.Application.Functions.Authors.Command.Create
{
	public class CreateAuthorCommand : IRequest<AuthorDto>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
