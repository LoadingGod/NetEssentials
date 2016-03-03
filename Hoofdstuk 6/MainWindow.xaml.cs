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

namespace Hoofdstuk_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int cars = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CarEnters(object sender, RoutedEventArgs e)
        {
            cars = cars + 1;
            label.Content = cars + " Cars in the park";
        }

        private void CarLeaves(object sender, RoutedEventArgs e)
        {
            cars = cars - 1;
            if(cars <= 0)
            {
                cars = 0;
            }
            label.Content = cars + " Cars in the park";
        }
        
    }
}
