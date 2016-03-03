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

namespace Oefening6._3
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
        int som;
        int gemiddelde;
        int getal;
        int clicks;
        private Random randomNumber = new Random();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            getal = randomNumber.Next(200, 401);
            som = som + getal;
            clicks++;
            gemiddelde = som / clicks;
            rnglabel.Content = getal;
            somLabel.Content = som;
            gemiddeldeLabel.Content = gemiddelde;
        }
    }
}
