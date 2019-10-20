using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
	public class Inventory
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Inventory()
		{
			this.guns = new HashSet<Inventory_gun>();
		}

		[Key]
		public int id { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Inventory_gun> guns { get; set; }
	}
}
