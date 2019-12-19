using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects.Models;

namespace Objects.Chain
{
	public class ShotgunDealer : Handler
	{
		public override void Request(Gun gun)
		{
			if (gun.type == "Gun2")
			{
				Debug.WriteLine("Shotgun dealer handed your gun");
			}
			else if (handler != null)
			{
				handler.Request(gun);
			}
		}
	}
}
