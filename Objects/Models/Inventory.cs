using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Objects.Models
{
	public class Inventory
	{
		public int id { get; set; }
		
		public  ICollection<InventoryGun> Guns { get; set; }
	}
}
