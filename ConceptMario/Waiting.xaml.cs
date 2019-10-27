using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using Objects.Models;

namespace ConceptMario
{
	/// <summary>
	/// Interaction logic for Waiting.xaml
	/// </summary>
	public partial class Waiting : Window
	{
		public Waiting()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{

			//await Matchmaking();
			//StartThreadMethod();
			//Frame = new DispatcherTimer();
			//Frame.Interval = TimeSpan.FromSeconds(1);
			//Frame.Tick += Frame_Tick;
			//Frame.Start();
		}

		/*private HttpAdapter Server = new HttpAdapter();
		private Room room;
		//private DispatcherTimer Frame = null;
		int id = Session.GetSession().GetId();
		private Thread checkThread;

		private void StartThreadMethod()
		{
			checkThread = new Thread(new ThreadStart(CheckGameComplete));
			checkThread.Start();

		}

		public async void CheckGameComplete()
		{
			while (true)
			{
				string count = await Server.GetLoggedUsers();
				this.Dispatcher.Invoke(() => { PlayersOnline.Content = count; });
				room =  await Server.GetRoom(room.id);
				if (room != null)
					if (room.fk_secondPlayer != null)
					{
						this.Dispatcher.Invoke(() =>
						{
							StartGame(room);
							KillTheThread();
						});
					}

				Thread.Sleep(150);
			}
		}

		private async void Frame_Tick(object sender, EventArgs e)
		{
			string count = await Server.GetLoggedUsers();
			PlayersOnline.Content = count;
			room = await Server.GetRoom(room.id);
			if (room != null)
				if (room.fk_secondPlayer != null)
				{
					MainWindow main = new MainWindow(room);
					main.Show();
					this.Close();
				}
		}

		private async Task Matchmaking()
		{
			room = await Server.StartMatchmaking(id);
			if (room.fk_secondPlayer == id)
			{
				MainWindow main = new MainWindow(room);
				main.Show();
				this.Close();
			}
		}

		private void StartGame(Room rm)
		{
			MainWindow main = new MainWindow(rm);
			main.Show();
			this.Close();
		}

		[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
		private void KillTheThread()
		{
			checkThread.Interrupt();
			checkThread.Abort();
		}*/

		private void btnClose_Click_1(object sender, RoutedEventArgs e)
		{
			//await Server.StopMatchmaking(room.id);
			Menu menu = new Menu();
			menu.Show();
			this.Close();
		}
	}
}
