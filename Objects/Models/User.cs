using System.Collections.Generic;

namespace Objects.Models
{
	public class User
	{
		public int id { get; set; }
		public string username { get; set; }
		public string password { get; set; }
		public int gold { get; set; }
		public bool status { get; set; }
	}
}
