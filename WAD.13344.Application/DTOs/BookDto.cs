namespace WAD._13344.Application.DTOs
{
	public class BookDto
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public AuthorDto Author { get; set; }
		public int PagesCount { get; set; }
		public DateTime PublicationDate { get; set; }
		public CategoryDto Category { get; set; }
	}
}
