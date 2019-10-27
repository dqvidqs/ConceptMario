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
		public virtual DbSet<InventoryGun> InventoryGuns { get; set; }
		public virtual DbSet<Room> Rooms { get; set; }
	}
}
