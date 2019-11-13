using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects.Models;

namespace ConceptMario
{
	[Serializable]
	public class Session
	{
		private static Session _session;
		private static readonly User User = new User();
		private static readonly Inventory Inventory= new Inventory();
		private static readonly object LockObj = new object();

		private Session() { }

		public static Session GetSession()
		{
			lock (LockObj)
			{
				if (_session != null)
					return _session;
				_session = new Session();
				return _session;
			}
		}

		public void Login(int id, string username)
		{
			User.id = id;
			User.username = username;
		}

		public void SetInventory(Inventory inv)
		{
			Inventory.id = inv.id;
			Inventory.Guns = inv.Guns;
		}

		public List<InventoryGun> GetUserGuns()
		{
			return Inventory.Guns.ToList();
		}

		public int GetId()
		{
			if (User != null)
				return User.id;
			return -1;
		}
	}
}
