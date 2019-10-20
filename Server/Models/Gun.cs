﻿using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
	public class Gun
	{
		[Key]
		public int id { get; set; }
		public string type { get; set; }
		public int fire_rate { get; set; }
		public int ammo { get; set; }
		public int damage { get; set; } 
	}
}
