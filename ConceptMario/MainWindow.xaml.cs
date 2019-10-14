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
using ConceptMario;

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
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			Frame = new DispatcherTimer();
			Frame.Interval = TimeSpan.FromSeconds(MetaData.FPS);
			Frame.Tick += Frame_Tick;
			Player = new Player(25, 25);
			Player2 = new Player(25, 25);
			Map = new Map(Player, Player2);
			MainGrind.Children.Add(Map.Get());
			Frame.Start();
		}
		//---------------------------------------------------
		//          Frames or Iterations
		//---------------------------------------------------
		private async void Frame_Tick(object sender, EventArgs e)
		{
			Map.UpdatePlayer(Player);
			Player.Move();
			await loadPlayer();
			Map.UpdatePlayer(Player2);
			await updatePlayer(new Character { id = Session.GetSession().GetId(), x = Player.GetX(), y = Player.GetY() });
			//throw new NotImplementedException();
		}

		async Task loadPlayer()
		{
			string page;
			int id = Session.GetSession().GetId();
			if (id == 1)
			{
				page = "https://localhost:44353/api/characters/2";
			}
			else
			{
				page = "https://localhost:44353/api/characters/1";

			}
			HttpClient client = new HttpClient();
			HttpResponseMessage respones = await client.GetAsync(page);
			HttpContent content = respones.Content;
			string data = await content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<Character>(data);
			if (data != null)
			{
				Player2.update(result.x, result.y);
			}

		}
		async Task updatePlayer(Character chara)
		{
			string page = "https://localhost:44353/api/characters/" + Session.GetSession().GetId().ToString();
			HttpClient client = new HttpClient();
			HttpResponseMessage respones = await client.PutAsync(page, new StringContent(
   JsonConvert.SerializeObject(chara), Encoding.UTF8, "application/json"));

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
