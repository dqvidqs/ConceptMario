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

namespace ConceptMario
{
	/// <summary>
	/// Interaction logic for Register.xaml
	/// </summary>
	public partial class Register : Window
	{
		private HttpAdapter Server = new HttpAdapter();
		public Register()
		{
			InitializeComponent();
		}

		private void btnRegister_Click_1(object sender, RoutedEventArgs e)
		{
			String message = "Invalid Credentials";
			try
			{
				RegisterPlayer(txtUser.Text.ToString(), txtPass.Password.ToString());
			}
			catch (Exception ex)
			{
				message = ex.Message.ToString();
			}
		}

		private void btnClose_Click_2(object sender, RoutedEventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Close();
		}

		async void RegisterPlayer(string username, string password)
		{
			var result = await Server.Register(username, password);
			if (result != null)
			{
				Login login = new Login();
				login.Show();
				this.Close();
			}

		}
	}
}
