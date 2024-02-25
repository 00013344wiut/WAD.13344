using AutoMapper;
using MediatR;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Interfaces;
using WAD._13344.Domain.Models;

namespace WAD._13344.Application.Functions.Categories.Command.Create
{
	public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CategoryDto>
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IMapper _mapper;

		public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
		{
			_categoryRepository = categoryRepository;
			_mapper = mapper;
		}

		public async Task<CategoryDto> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
		{
			var category = new Category
			{
				CategoryName = request.CategoryName
			};

			await _categoryRepository.CreateAsync(category);

			return _mapper.Map<CategoryDto>(category);
		}
	}
}
