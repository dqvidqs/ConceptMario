using System.ComponentModel.DataAnnotations;

namespace Objects.Models
{
	public class Inventory_gun
	{
		[Key]
		public int id { get; set; }
		public int fk_inventory { get; set; }
		public int fk_gun { get; set; }

		public virtual Gun gun { get; set; }
	}
}
