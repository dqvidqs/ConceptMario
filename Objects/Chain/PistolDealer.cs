using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects.Models;
using System.Diagnostics;

namespace Objects.Chain
{
	public class PistolDealer : Handler
	{
		public override void Request(Gun gun)
		{
			if (gun.type == "Gun1")
			{
				Debug.WriteLine("Pistol dealer handed your gun");
			}
			else if (handler != null)
			{
				handler.Request(gun);
			}
		}
	}
}
