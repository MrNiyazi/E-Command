using System.ComponentModel.DataAnnotations;

namespace E_Command.Models.Class
{
	public class Contact
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		[MaxLength(200)]
		public string Description { get; set; }
		public string ImageUrl { get; set; }

	    public decimal Latitude { get; set; }
		public decimal Longitude { get; set; }
	}
}
