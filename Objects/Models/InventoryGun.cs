using System.ComponentModel.DataAnnotations;

namespace Objects.Models
{
	public class InventoryGun
	{
		public int id { get; set; }
		public int Inventoryid { get; set; }
		public int Gunid { get; set; }

		public Gun Gun { get; set; }
		
	}
}
