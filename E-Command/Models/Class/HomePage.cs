using System.ComponentModel.DataAnnotations;

namespace E_Command.Models.Class
{
	public class HomePage
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageUrl {  get; set; }
	}
}
