using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WAD._13344.Application.Interfaces;
using WAD._13344.Infrastructure.Data;
using WAD._13344.Infrastructure.Repositories;

namespace WAD._13344.Infrastructure
{
	public static class Configurations
	{
		public static IServiceCollection InfrastructureServices(
			this IServiceCollection services,
			IConfiguration configuration
		)
		{
			services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
			services.AddScoped<IBookRepository, BookRepository>();
			services.AddScoped<IAuthorRepository, AuthorRepository>();
			services.AddScoped<ICategoryRepository, CategoryRepository>();

			return services;
		}
	}
}
