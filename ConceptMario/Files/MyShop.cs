using System;
using System.Collections.Generic;
using Objects.Models;
using Objects.Strategy;
using Objects.State;

namespace ConceptMario.Files
{
	public class MyShop
	{
		public  List<Gun> Guns { get; }

		private static MyShop _shop;
		public static ISaleStrategy _saleStrategy;

		Context priceSetter;


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
			priceSetter = new Context();
			//SetSaleStrategy();
			GetGuns();
		}

		private async void GetGuns()
		{
			ResponseToJson Server = new ResponseToJson();
			var result = await Server.GetGuns();

			result.price += priceSetter.GetPrice();
				//item.price = _saleStrategy.GetPrice(item.price);
				Guns.Add(result);
			
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
