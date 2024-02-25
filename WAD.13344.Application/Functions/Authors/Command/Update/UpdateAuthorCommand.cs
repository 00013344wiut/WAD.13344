using MediatR;
using WAD._13344.Application.DTOs;

namespace WAD_13344.Application.Functions.Authors.Command.Update
{
	public class UpdateAuthorCommand : IRequest<AuthorDto>
	{
		public int AuthorId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
