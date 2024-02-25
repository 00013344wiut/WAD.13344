using Microsoft.EntityFrameworkCore;
using WAD._13344.Domain.Models;

namespace WAD._13344.Infrastructure.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Category> Categories { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Configure relationships here

			// One-to-Many relationship between Author and Book
			modelBuilder.Entity<Author>()
				.HasMany(a => a.Books)
				.WithOne(b => b.Author)
				.HasForeignKey(b => b.AuthorId)
				.OnDelete(DeleteBehavior.Cascade);

			// Many-to-One relationship between Book and Category
			modelBuilder.Entity<Book>()
				.HasOne(b => b.Category)
				.WithMany(c => c.Books)
				.HasForeignKey(b => b.CategoryId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
