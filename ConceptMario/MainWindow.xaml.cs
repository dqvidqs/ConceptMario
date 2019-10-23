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
		private Player Player = null;
		private Player Player2 = null;
		private Player oldOne = new Player(25, 25);
		private HttpAdapter Server = new HttpAdapter();
        private bool[] Updates;

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			Frame = new DispatcherTimer();
			Frame.Interval = TimeSpan.FromSeconds(MetaData.FPS);
			// Su tokiu intervalu labai gerai matos multiplayer game bet belekaip letai
			//Frame.Interval = TimeSpan.FromSeconds(0.25);
			Frame.Tick += Frame_Tick;
			Player = new Player(25, 25);
			Player2 = new Player(25, 25);
            Map = new Map(Player, Player2, 0);
			MainGrind.Children.Add(Map.Get());
			Frame.Start();
		}
		//---------------------------------------------------
		//          Frames or Iterations
		//---------------------------------------------------
		private async void Frame_Tick(object sender, EventArgs e)
		{

            Updates = Map.UpdatePlayer(Player);
			Player.Move();
            if (Updates[0])
            {
                await updateDiamond();
            }

            /*await loadPlayer();
            await RemoveDiamond();

			Map.UpdatePlayer(Player2);*/
			//throw new NotImplementedException();
		}

		async Task loadPlayer()
		{
			int id = Session.GetSession().GetId();
			if (id == 1)
			{
				var result = await Server.GetTeammate(2);
				if (result != null)
				{
					Player2.update(result.x, result.y);
				}
			}
			else
			{
				var result = await Server.GetTeammate(1);
				if (result != null)
				{
					Player2.update(result.x, result.y);
				}

			}

		}
		async Task updatePlayer(Character chara)
		{
            await Server.UpdateCharacter(Session.GetSession().GetId(), chara);
		}
        async Task updateDiamond()
        {
            await Server.UpdateDiamond(new DiamondModel() { id = 1, x = Player.GetCenterX(), y = Player.GetCenterY() });
        }
        async Task RemoveDiamond()
        {
            try
            {
                await Server.DeleteDiamond();
                Map.CatchDiamond(Player2);
            }
            catch { }
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
			}
		}

	}
}
