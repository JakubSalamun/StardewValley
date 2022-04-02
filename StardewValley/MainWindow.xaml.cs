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

            //*************************
            //przerobić IF z daniem po zmianie sezonu
         

            //if (help.seasonsName == "Spring" && help.seasonsDay == 29)
            //{
            //    var serializationSummer= help.seasonsName = (calendar.DataContext= "Summer").ToString();
            //    var serializationSummerDay =help.seasonsDay = 1;
            //    methods.HelpSerialize(serializationSummerDay, serializationSummer);
            //}
            //if (help.seasonsName == "Summer" && help.seasonsDay == 29)
            //{
            //    var serializationFall = help.seasonsName = (calendar.DataContext = "Fall").ToString();
            //    var serializationFallDay = help.seasonsDay = 1;
            //    methods.HelpSerialize(serializationFallDay, serializationFall);
            //}
            //if (help.seasonsName == "Fall" && help.seasonsDay == 29)
            //{
            //    var serializationWinter = help.seasonsName = (calendar.DataContext = "Winter").ToString();
            //    var serializationWinterDay = help.seasonsDay = 1;
            //    methods.HelpSerialize(serializationWinterDay, serializationWinter);
            //}
            //if (help.seasonsName == "Winter" && help.seasonsDay == 29)
            //{
            //    var serializationSpring = help.seasonsName = (calendar.DataContext = "Spring").ToString();
            //    var serializationSpringDay = help.seasonsDay = 1;
            //    methods.HelpSerialize(serializationSpringDay, serializationSpring);
            //}

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
