using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects.Models;

namespace Objects.Chain
{
	public abstract class Handler
	{
		protected Handler handler;

		public void SetHandler(Handler handler)
		{
			this.handler = handler;
		}

		public abstract void Request(Gun gun);
	}
}
