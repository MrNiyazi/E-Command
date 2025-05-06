using System.ComponentModel.DataAnnotations;

namespace E_Command.Models.Class
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string ImageUrl {  get; set; }		
		public bool  IsHome { get; set; }
		public bool IsStock { get; set; }
		public DateTime CreatedDate { get; set; }
		public int StockQuantity { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }


	}
}
