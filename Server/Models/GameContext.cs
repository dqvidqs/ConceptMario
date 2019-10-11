using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Models
{
	public class GameContext : DbContext
	{
		public GameContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}

		public DbSet<User> Users { get; set; }

		public DbSet<Server.Models.Character> Character { get; set; }
		//public DbSet<User> Characters { get; set; }
	}
}
