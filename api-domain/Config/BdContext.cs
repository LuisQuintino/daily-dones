using api_domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace api_domain.Config
{
	public class BdContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				var connStr = "Database=dailydones;Port=3306;Data Source=127.0.0.1;User Id=root;Password=basedeelite;SslMode=none;";
				optionsBuilder.UseMySQL(connStr);
			}
		}

		public DbSet<Usuario> Usuarios { get; set; }
	}
}
