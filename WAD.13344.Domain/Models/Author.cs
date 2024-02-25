namespace WAD._13344.Domain.Models
{
	public class Author
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int BooksCount { get; set; }

		public ICollection<Book>? Books { get; set; }
	}
}
