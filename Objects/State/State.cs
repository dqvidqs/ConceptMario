using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.State
{
	public abstract class State
	{
		protected int price;

		public int Price
		{
			get { return price; }
			set { price = value; }
		}

		public abstract int Handle(Context context);
	}
}
