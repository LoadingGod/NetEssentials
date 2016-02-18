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

namespace Demo
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Ja";
            label1.Content = "Ja";
            label2.Content = "Ja";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Nee";
            label1.Content = "Nee";
            label2.Content = "Nee";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "A";
            label1.Content = "B";
            label2.Content = "C";
        }
    }
}
