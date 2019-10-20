using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
	public class Room
	{
		[Key]
		public int id { get; set; }
		public int level { get; set; }
		public int fk_firstPlayer { get; set; }
		public Nullable<int> fk_secondPlayer { get; set; }

		public virtual Character palyer1 { get; set; }
		public virtual Character palyer2 { get; set; }
	}
}
