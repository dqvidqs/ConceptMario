using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ConceptMario
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
	    private IJson Server = new ResponseToJson();

		private async void Application_Exit(object sender, ExitEventArgs e)
		{
            await Server.Logout(Session.GetSession().GetId());
		}
	}
}
