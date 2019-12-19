using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects.Models;

namespace Objects.Chain
{
	public class SemiAutoDealer : Handler
	{
		public override void Request(Gun gun)
		{
			if (gun.type == "Gun3")
			{
				Debug.WriteLine("Semi-auto gun dealer handed your gun");
			}
			else if (handler != null)
			{
				handler.Request(gun);
			}
		}
	}
}
