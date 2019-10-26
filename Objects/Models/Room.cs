using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Objects.Models
{
	public class Room
	{
		public int id { get; set; }
		public int level { get; set; }
		public int fk_firstPlayer { get; set; }
		public Nullable<int> fk_secondPlayer { get; set; }
	}
}
