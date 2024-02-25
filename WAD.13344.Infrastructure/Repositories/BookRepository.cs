using WAD._13344.Application.Interfaces;
using WAD._13344.Domain.Models;
using WAD._13344.Infrastructure.Data;
using WAD._13344.Infrastructure.Repositories.BaseRepository;

namespace WAD._13344.Infrastructure.Repositories
{
	public class BookRepository : BaseRepository<Book>, IBookRepository
	{
		public BookRepository(AppDbContext context) : base(context)
		{ 

		}
	}
}
