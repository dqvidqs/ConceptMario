using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Newtonsoft.Json;
using ConceptMario.Models;
using ConceptMario.Assets;
using Objects.Models;
using ConceptMario.Assets.Characters;

namespace ConceptMario
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		//---------------------------------------------------
		//          Creating new objects
		//---------------------------------------------------
		private Map Map = null;
		private DispatcherTimer Frame = null;
		private DispatcherTimer Frame2 = null;
		private Player Player = null;
		private Player Player2 = null;
		private Player oldOne = new Player(25, 25);
		private HttpAdapter Server = new HttpAdapter();
        private bool[] Updates;
        private bool send = true;

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			Frame = new DispatcherTimer();
			Frame2 = new DispatcherTimer();
			Frame.Interval = TimeSpan.FromSeconds(MetaData.FPS);
			Frame2.Interval = TimeSpan.FromSeconds(0.25);
			Frame.Tick += Frame_Tick;
			Frame2.Tick += Frame_Tick2;
			Player = new Player(25, 25);
			Player2 = new Player(25, 25);
			oldOne.Update(Player.GetX(), Player.GetY());
			Map = new Map(Player, Player2, 0);
			MainGrind.Children.Add(Map.Get());
			Frame.Start();
			Frame2.Start();
		}
		//---------------------------------------------------
		//          Frames or Iterations
		//---------------------------------------------------
		private async void Frame_Tick(object sender, EventArgs e)
		{

            Updates = Map.UpdatePlayer(Player);
			Player.Move();
            /*if (Updates[0])
            {
                await UpdateDiamond();
            }*/

            if (Math.Abs(Player.GetCenterX() - oldOne.GetCenterX()) > 5 ||
                Math.Abs(Player.GetCenterY() - oldOne.GetCenterY()) > 5)
            {
	            send = true;
            }

			/*await loadPlayer();
            await RemoveDiamond();

			Map.UpdatePlayer(Player2);*/
			//throw new NotImplementedException();
		}

		private async void Frame_Tick2(object sender, EventArgs e)
		{
			if (send)
				await UpdatePlayer(new Character
				{
					id = Session.GetSession().GetId(),
					x = Player.GetX(),
					y = Player.GetY(),
					fk_inventory = Session.GetSession().GetId(),
					fk_user = Session.GetSession().GetId()
				});
			await LoadPlayer();
			Map.UpdatePlayer(Player2);
		}

		async Task LoadPlayer()
		{
			int id = Session.GetSession().GetId();
			if (id == 1)
			{
				var result = await Server.GetTeammate(2);
				if (result != null)
				{
					Player2.Update(result.x, result.y);
				}
			}
			else
			{
				var result = await Server.GetTeammate(1);
				if (result != null)
				{
					Player2.Update(result.x, result.y);
				}

			}

		}
		async Task UpdatePlayer(Character chara)
		{
			send = false;
			await Server.UpdateCharacter(Session.GetSession().GetId(), chara);
		}
        //---------------------------------------------------
        //          Players Controls
        //---------------------------------------------------       
        private void Window_KeyDown(object sender, KeyEventArgs e)//Pushed buttons
		{
			switch (e.Key)
			{
				case (Key.Left):
					Player.Left = true;
					break;
				case (Key.Right):
					Player.Right = true;
					break;
				case (Key.Up):
					Player.IsJump = true;
                    break;
                case (Key.Space):
                    Player.IsShooting = true;
					break;
			}
		}

		private void Window_KeyUp(object sender, KeyEventArgs e)//Released buttons
		{
			switch (e.Key)
			{
				case (Key.Left):
					Player.Left = false;
					break;
				case (Key.Right):
					Player.Right = false;
					break;
				case (Key.Up):
					Player.IsJump = false;
					break;
                case (Key.Space):
                    Player.IsShooting = false;
                    break;
            }
		}

	}
}
