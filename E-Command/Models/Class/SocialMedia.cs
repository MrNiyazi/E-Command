using System.ComponentModel.DataAnnotations;

namespace E_Command.Models.Class
{
	public class SocialMedia
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string SocialUrl { get; set; }
		public string SocialIcon {  get; set; }
	}
}
