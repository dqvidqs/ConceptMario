using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ConceptMario;
using ConceptMario.Files;
using Objects.Models;
using Objects.Chain;

namespace ConceptMario
{
	/// <summary>
	/// Interaction logic for Shop.xaml
	/// </summary>
	public partial class Shop : Window
	{
		List<Gun> guns;
		Handler st;
		Handler nd;
		Handler rd;
		Handler th;
		//private List<InventoryGun> userGuns;
		public Shop()
		{
			InitializeComponent();
			GetGuns();
			Dealers();
		}

		public void GetGuns()
		{
			guns = MyShop.GetShop().Guns;
			//userGuns = Session.GetSession().GetUserGuns();

		}

		private void SetDealers()
		{
			st = new PistolDealer();
			nd = new ShotgunDealer();
			rd = new SemiAutoDealer();
			th = new AutomaticDealer();
			st.SetHandler(nd);
			nd.SetHandler(rd);
			rd.SetHandler(th);
		}

		private void Dealers()
		{
			SetDealers();
			Gun g1 = new Gun { id = 55, type = "Gun1", ammo = 55, damage = 55, fire_rate = 55, price = 55 };
			Gun g2 = new Gun { id = 55, type = "Gu21", ammo = 55, damage = 55, fire_rate = 55, price = 55 };
			Gun g3 = new Gun { id = 55, type = "Gun2", ammo = 55, damage = 55, fire_rate = 55, price = 55 };
			Gun g4 = new Gun { id = 55, type = "Gun4", ammo = 55, damage = 55, fire_rate = 55, price = 55 };
			Gun g5 = new Gun { id = 55, type = "Gun3", ammo = 55, damage = 55, fire_rate = 55, price = 55 };
			st.Request(g1);
			st.Request(g2);
			st.Request(g3);
			st.Request(g4);
			st.Request(g5);
		}

		private void btnMenu_Click_1(object sender, RoutedEventArgs e)
		{
			Menu menu = new Menu();
			menu.Show();
			this.Close();
		}
	}
}
