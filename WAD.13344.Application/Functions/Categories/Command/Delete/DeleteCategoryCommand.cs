using MediatR;

namespace WAD._13344.Application.Functions.Categories.Command.Delete
{
	public class DeleteCategoryCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
