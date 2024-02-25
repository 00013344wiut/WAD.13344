using AutoMapper;
using WAD._13344.Application.DTOs;
using WAD._13344.Application.Functions.Books.Query.GetById;
using WAD._13344.Domain.Models;

namespace WAD._13344.Application.Profiles
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			CreateMap<Author, AuthorDto>();
			CreateMap<Category, CategoryDto>();
			CreateMap<Book, BookDto>();
			CreateMap<Book, GetBookByIdResponse>();
		}
	}
}
