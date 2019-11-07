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

namespace ConceptMario
{
	/// <summary>
	/// Interaction logic for Shop.xaml
	/// </summary>
	public partial class Shop : Window
	{
		List<Gun> guns;
		//private List<InventoryGun> userGuns;
		public Shop()
		{
			InitializeComponent();
			GetGuns();
		}

		public void GetGuns()
		{
			guns = MyShop.GetShop().Guns;
			//userGuns = Session.GetSession().GetUserGuns();
		}

		private void btnMenu_Click_1(object sender, RoutedEventArgs e)
		{
			Menu menu = new Menu();
			menu.Show();
			this.Close();
		}
	}
}
