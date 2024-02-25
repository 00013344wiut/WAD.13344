using MediatR;

namespace WAD._13344.Application.Functions.Authors.Command.Delete
{
	public class DeleteAuthorCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
