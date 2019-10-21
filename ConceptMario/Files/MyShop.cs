using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceptMario.Models;
using ConceptMario.Strategy;

namespace ConceptMario
{
	public class MyShop
	{
		public  List<Gun> Guns { get; }

		private static MyShop _shop;
		public static ISaleStrategy _saleStrategy;

		private static readonly object LockObj = new object();
		public static MyShop GetShop()
		{
			lock (LockObj)
			{
				if (_shop != null)
				{
					SetSaleStrategy();
					return _shop;
				}

				_shop = new MyShop();
				return _shop;
			}
		}

		private MyShop()
		{
			Guns = new List<Gun>();
			SetSaleStrategy();
			GetGuns();
		}

		private async void GetGuns()
		{
			HttpAdapter Server = new HttpAdapter();
			var result = await Server.GetGuns();
			foreach (var item in result)
			{
				item.price = _saleStrategy.GetPrice(item.price);
				Guns.Add(item);
			}
		}

		public static void SetSaleStrategy()
		{
			var now = DateTime.Now.Hour;

			if (now < 4 || now >= 20)
			{
				_saleStrategy = new NightSaleStrategy();
			}
			else if (now <= 12)
			{
				_saleStrategy = new MorningSaleStrategy();
			}
			else
			{
				_saleStrategy = new AfternoonSaleStrategy();
			}

		}
	}
}
