using AutoMapper;
using MediatR;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Interfaces;

namespace WAD._13344.Application.Functions.Categories.Command.Update
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, CategoryDto>
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IMapper _mapper;

		public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
		{
			_categoryRepository = categoryRepository;
			_mapper = mapper;
		}

		public async Task<CategoryDto> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
		{
			var category = await _categoryRepository.GetByIdAsync(request.CategoryId);

			if (category == null)
			{
				return null;
			}

			category.CategoryName = request.CategoryName;

			await _categoryRepository.UpdateAsync(category);

			return _mapper.Map<CategoryDto>(category);
		}
	}
}
