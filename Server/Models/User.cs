﻿using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
	public class User
	{
		[Key]
		public int id { get; set; }
		public string username { get; set; }
		public string password { get; set; }
	}
}
