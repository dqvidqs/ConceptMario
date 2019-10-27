using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using ConceptMario.Models;
using ConceptMario;
using ConceptMario.Files;
using Newtonsoft.Json;

namespace ConceptMario
{
	/// <summary>
	/// Interaction logic for Login.xaml
	/// </summary>
	public partial class Login : Window
	{
		private HttpAdapter Server = new HttpAdapter();
		public Login()
		{
			InitializeComponent();
		}

		private void btnLogin_Click_1(object sender, RoutedEventArgs e)
		{
			String message = "Invalid Credentials";
			try
			{
				LoginPlayer(txtUserId.Text.ToString(), txtPassword.Password.ToString());
				message = "1";
			}
			catch (Exception ex)
			{
				message = ex.Message.ToString();
			}
		}

		private void btnClose_Click_1(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void btnRegister_Click_1(object sender, RoutedEventArgs e)
		{
			Register reg = new Register();
			reg.Show();
			this.Close();
		}

		private async void LoginPlayer(string username, string password)
		{
			String message ="";
			try
			{
				var result = await Server.Login(username, password);
				if (result != null)
				{
					Session.GetSession().Login(result.id, result.username);
					message = "1";
				}
				var result2 = await Server.GetInventory(result.id);
				if (result2 != null)
				{
					Session.GetSession().SetInventory(result2);
					message += "1";
				}
			}
			catch (Exception ex)
			{
				message = "Invalid Credentials\n"+ "or\n" + ex.Message.ToString();
			}

			if (message == "11")
			{
				MyShop.GetShop();
				Menu menu = new Menu();
				menu.Show();
				this.Close();
			}
			else
				MessageBox.Show(message, "Info");
		}
	}
}