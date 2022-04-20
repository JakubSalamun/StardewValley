using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
        CalendarWindow calendar = new CalendarWindow();
        Methods methods = new Methods();


        public MainWindow()
        {
            InitializeComponent();
        
        }

        private void TV_Click(object sender, RoutedEventArgs e)
        {
            var help = methods.HelpDeserialize();
            methods.TvNews(help.seasonsDay);
        }

        private void Calendar_Click(object sender, RoutedEventArgs e)
        {

      

            methods.HelpSezons();
            var help = methods.HelpDeserialize();
            calendar.DataContext = help.seasonsName;

            foreach (var item in calendar.labelList)
            {
                if (Convert.ToInt32( item.Content) <= help.seasonsDay)
                {
                    item.Background = Brushes.Green;
                }
                if (Convert.ToInt32(item.Content)> help.seasonsDay)
                {
                    item.Background = Brushes.White;
                }
            }           
            calendar.ShowDialog();
        }

        private void Bed_Click(object sender, RoutedEventArgs e)
        {
            var help = methods.HelpDeserialize();

            var _curentDay = help.seasonsDay;
            _curentDay += 1;
            MessageBox.Show("Nastał dzień: "+_curentDay.ToString());

            methods.HelpCurentDay(help.seasonsDay);
        }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
