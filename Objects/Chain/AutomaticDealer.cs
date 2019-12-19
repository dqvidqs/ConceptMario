using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects.Models;

namespace Objects.Chain
{
	public class AutomaticDealer : Handler
	{
		public override void Request(Gun gun)
		{
			if (gun.type == "Gun4")
			{
				Debug.WriteLine("Automatic gun dealer handed your gun");
			}
			else 
			{
				Debug.WriteLine("Noone has your required gun :(");	
			}
		}
	}
}
