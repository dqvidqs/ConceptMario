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

		async void LoginPlayer(string username, string password)
		{
			var result = await Server.Login(username, password);
			if (result != null)
			{
				Session.GetSession().Login(result.id, result.username);
				MainWindow mainWindow = new MainWindow();
				mainWindow.Show();
				this.Close();
			}

		}
	}
}