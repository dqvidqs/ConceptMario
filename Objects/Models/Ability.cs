using System.ComponentModel.DataAnnotations;

namespace Objects.Models
{
	public class Ability
	{
		[Key]
		public int id { get; set; }
		public string type { get; set; }
	}
}
