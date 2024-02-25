namespace WAD._13344.Domain.Models
{
	public class Category 
	{ 
		public int Id { get; set; }

		public string CategoryName { get; set; }

		public ICollection<Book>? Books { get; set; }
	}
}
