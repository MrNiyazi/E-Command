using Microsoft.EntityFrameworkCore;


namespace E_Command.Models.Class

{
	public class Context:DbContext
	{
		public DbSet<About> Abouts { get; set; }
		public DbSet<Admin> Admins { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<HomePage> HomePages { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<SocialMedia> SocialMedias {  get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				// Buraya kendi bağlantı cümleni yaz
				optionsBuilder.UseSqlServer("Server=BERAT\\SQLEXPRESS;Database=ETicaretDb;Trusted_Connection=True;TrustServerCertificate=True;");
			}
		}
	}
}
