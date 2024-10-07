using Microsoft.EntityFrameworkCore;
using RestAPI.Data.Models;

namespace RestAPI.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		
		
		}
		public DbSet<Produit> Produits { get; set; }

	}
}
