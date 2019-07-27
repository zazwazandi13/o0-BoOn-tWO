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

namespace BumbleBee
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

        private void Button_SizeChanged(object sender, SizeChangedEventArgs e)
        {
          //  allows for text size to actually be reasonalbe
            myButton.FontSize = myButton.ActualWidth / 10;
        }

        private void Scoreboard_Page(object sender, RoutedEventArgs e)
        {
            Main.Content = new scoreboardMain();
        }
    }
}
