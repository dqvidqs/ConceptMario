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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Frame = new DispatcherTimer();
            Frame.Interval = TimeSpan.FromSeconds(MetaData.FPS);
            Frame.Tick += Frame_Tick;
            Player = new Player(25, 25);
            Map = new Map(Player);
            MainGrind.Children.Add(Map.Get());
            Frame.Start();
        }
        //---------------------------------------------------
        //          Frames or Iterations
        //---------------------------------------------------
        private void Frame_Tick(object sender, EventArgs e)
        {           
            Map.UpdatePlayer(Player);
            Player.Move();
            //throw new NotImplementedException();
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
