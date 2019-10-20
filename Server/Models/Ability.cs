using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
	public class Ability
	{
		[Key]
		public int id { get; set; }
		public string type { get; set; }
	}
}
