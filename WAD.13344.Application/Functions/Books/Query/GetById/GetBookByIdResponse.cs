namespace WAD._13344.Application.Functions.Books.Query.GetById
{
	public class GetBookByIdResponse
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int AuthorId { get; set; }
		public int PagesCount { get; set; }
		public DateTime PublicationDate { get; set; }
		public int CategoryId { get; set; }
	}
}
