using System.ComponentModel.DataAnnotations;

namespace E_Command.Models.Class
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string Name { get; set; }
	}
}
