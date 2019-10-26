using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceptMario.Models;
using Objects.Models;

namespace ConceptMario
{
	[Serializable]
	public class Session
	{
		private static Session _session;
		private static readonly User user = new User();
		private static readonly object lockObj = new object();

		private Session() { }

		public static Session GetSession()
		{
			lock (lockObj)
			{
				if (_session != null)
					return _session;
				_session = new Session();
				return _session;
			}
		}

		public void Login(int id, string username)
		{
			user.id = id;
			user.username = username;
		}

		public int GetId()
		{
			if (user != null)
				return user.id;
			return -1;
		}
	}
}
