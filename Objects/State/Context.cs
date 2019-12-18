using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.State
{
	public class Context
	{
		private State _state;

		public State State
		{
			get { return _state; }
			set{ _state = value; }
		}

		public Context()
		{
			this._state = new MorningState();
		}

		public int GetPrice()
		{
			return _state.Handle(this);
		}
	}
}
