using Microsoft.EntityFrameworkCore;

namespace MicroService1.API.Models
{
	public class AppDbContext:DbContext
	{

		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{
			
		}

		public DbSet<Product> Products { get; set; }

	}
}
