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

namespace bronte_w_sdd_at2
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
        GameSettings _GameSettings = new GameSettings();

        private void PlayerClicksSpace (object sender, RoutedEventArgs e)
        {
            var space = (Button) sender;
            if (!String.IsNullOrWhiteSpace(space.Content?.ToString())) return;
            
            space.Content = _GameSettings.CurrentPlayer;

            var coordinates = space.Tag.ToString().Split(',');
            var xValue = int.Parse(coordinates[0]);
            var yValue = int.Parse(coordinates[1]);
            var buttonPosition = new position() { x = xValue, y = yValue };
            _GameSettings.UpdateBoard(buttonPosition, _GameSettings.CurrentPlayer);

            if (_GameSettings.PlayerWin())
            {
                WinScreen.Text = $"{_GameSettings.CurrentPlayer} WINS!!";
                WinScreen.Visibility = Visibility.Visible;
            }

            _GameSettings.SetNextPlayer();


        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            foreach ( var control in GridBoard.Children)
            {
                if(control is Button)
                {
                    ((Button)control).Content = String.Empty;
                }
                _GameSettings = new GameSettings();
                WinScreen.Visibility = Visibility.Collapsed;
            }
        }

      
    }
}
