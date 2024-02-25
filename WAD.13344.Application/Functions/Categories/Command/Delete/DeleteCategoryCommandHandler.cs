using MediatR;
using WAD._13344.Application.Interfaces;

namespace WAD._13344.Application.Functions.Categories.Command.Delete
{
	public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, bool>
	{
		private readonly ICategoryRepository _categoryRepository;

		public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
		{
			var category = await _categoryRepository.GetByIdAsync(request.Id);

			if (category == null)
			{
				// Handle not found scenario
				return false;
			}

			await _categoryRepository.DeleteAsync(request.Id);

			return true;
		}
	}
}
