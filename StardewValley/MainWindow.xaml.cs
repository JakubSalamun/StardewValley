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

namespace StardewValley
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

  

        private void TV_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TV News");
        }

        private void Calendar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Day of Year");
        }

        private void Bed_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sleep");
        }
    }
}
