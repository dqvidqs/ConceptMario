using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.State
{
	class NightState :State
	{


		public override int Handle(Context context)
		{
			StateChangeCheck(context);
			return 20;
		}

		private void StateChangeCheck(Context context)
		{
			var now = DateTime.Now.Hour;

			if (now<20)
			{
				context.State = new NightState();
			}
			else if (now <= 12 && now > 4)
			{
				context.State = new MorningState();
			}
		}
	}
}
