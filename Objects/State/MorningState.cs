using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.State
{
	class MorningState :State
	{
		public override int Handle(Context context)
		{
			StateChangeCheck(context);
			return -20;
		}

		private void StateChangeCheck(Context context)
		{
			var now = DateTime.Now.Hour;

			if (now < 4 || now >= 20)
			{
				context.State = new NightState();
			}
			else if (now > 12)
			{
				context.State = new AfternoonState();
			}
		}
	}
}
