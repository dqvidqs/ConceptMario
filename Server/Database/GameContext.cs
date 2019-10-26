using Microsoft.EntityFrameworkCore;
using Objects.Models;

namespace Server.Database
{
	public class GameContext : DbContext
	{
		public GameContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}

		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Character> Characters { get; set; }
		public virtual DbSet<Ability> Abilities { get; set; }
		public virtual DbSet<Gun> Guns { get; set; }
		public virtual DbSet<Inventory> Inventories { get; set; }
		public virtual DbSet<Inventory_gun> Inventory_Guns { get; set; }
		public virtual DbSet<Room> Rooms { get; set; }
		public virtual DbSet<Diamond> Diamond { get; set; }
	}
}
