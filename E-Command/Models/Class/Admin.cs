﻿using System.ComponentModel.DataAnnotations;

namespace E_Command.Models.Class
{
	public class Admin
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Password { get; set; }
	}
}
