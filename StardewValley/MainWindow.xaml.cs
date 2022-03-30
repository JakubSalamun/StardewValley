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
       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TV_Click(object sender, RoutedEventArgs e)
        {
            var help = HelpDeserialize();
            TvNews(help);
        }

        private void Calendar_Click(object sender, RoutedEventArgs e)
        {
            //problem :musimy zapisać JSON z listą ,by po wczytaniu calendar.labelList posiadało elementy
            //oczekiwany efekt: dodanie do listy z poziomu CalendarWindow 
            //do edycji D:\JSON\DayofSesons.json by zmienic dzień (nie ujete w planie)
            var help = HelpDeserialize();

            foreach (var item in calendar.labelList)
            {
                if (Convert.ToInt32( item.Content) <= help)
                {
                    item.Background = Brushes.Green;
                }
            }           
            calendar.ShowDialog();
        }

        private void Bed_Click(object sender, RoutedEventArgs e)
        {
            var help= HelpDeserialize();
            MessageBox.Show(calendar.labelList.Last().Content.ToString());

            HelpCurentDay(help);
        }

        private void HelpCurentDay(int help)
        {
            switch (help)
            {
                case 1:
                    calendar.labelList.Add(calendar.Label2);
                    HelpSerialize(Convert.ToInt32(calendar.Label2.Content));
                    break;
                case 2:
                    calendar.labelList.Add(calendar.Label3);
                    HelpSerialize(Convert.ToInt32(calendar.Label3.Content));
                    break;
                case 3:
                    calendar.labelList.Add(calendar.Label4);
                    HelpSerialize(Convert.ToInt32(calendar.Label4.Content));
                    break;
                case 4:
                    calendar.labelList.Add(calendar.Label5);
                    HelpSerialize(Convert.ToInt32(calendar.Label5.Content));
                    break;
                case 5:
                    calendar.labelList.Add(calendar.Label6);
                    HelpSerialize(Convert.ToInt32(calendar.Label6.Content));
                    break;
                case 6:
                    calendar.labelList.Add(calendar.Label7);
                    HelpSerialize(Convert.ToInt32(calendar.Label7.Content));
                    break;
                case 7:
                    calendar.labelList.Add(calendar.Label8);
                    HelpSerialize(Convert.ToInt32(calendar.Label8.Content));
                    break;
                case 8:
                    calendar.labelList.Add(calendar.Label9);
                    HelpSerialize(Convert.ToInt32(calendar.Label9.Content));
                    break;
                case 9:
                    calendar.labelList.Add(calendar.Label10);
                    HelpSerialize(Convert.ToInt32(calendar.Label10.Content));
                    break;
                case 10:
                    calendar.labelList.Add(calendar.Label11);
                    HelpSerialize(Convert.ToInt32(calendar.Label11.Content));
                    break;

                case 11:
                    calendar.labelList.Add(calendar.Label12);
                    HelpSerialize(Convert.ToInt32(calendar.Label12.Content));
                    break;
                case 12:
                    calendar.labelList.Add(calendar.Label13);
                    HelpSerialize(Convert.ToInt32(calendar.Label13.Content));
                    break;
                case 13:
                    calendar.labelList.Add(calendar.Label14);
                    HelpSerialize(Convert.ToInt32(calendar.Label14.Content));
                    break;
                case 14:
                    calendar.labelList.Add(calendar.Label15);
                    HelpSerialize(Convert.ToInt32(calendar.Label15.Content));
                    break;
                case 15:                 
                        calendar.labelList.Add(calendar.Label16);
                        HelpSerialize(Convert.ToInt32(calendar.Label16.Content));
                        break;
                case 16:
                    calendar.labelList.Add(calendar.Label17);
                    HelpSerialize(Convert.ToInt32(calendar.Label17.Content));
                    break;
                case 17:
                    calendar.labelList.Add(calendar.Label18);
                    HelpSerialize(Convert.ToInt32(calendar.Label18.Content));
                    break;
                case 18:
                    calendar.labelList.Add(calendar.Label19);
                    HelpSerialize(Convert.ToInt32(calendar.Label19.Content));
                    break;
                case 19:
                    calendar.labelList.Add(calendar.Label20);
                    HelpSerialize(Convert.ToInt32(calendar.Label20.Content));
                    break;
                case 20:
                    calendar.labelList.Add(calendar.Label21);
                    HelpSerialize(Convert.ToInt32(calendar.Label21.Content));
                    break;
                case 21:
                    calendar.labelList.Add(calendar.Label22);
                    HelpSerialize(Convert.ToInt32(calendar.Label22.Content));
                    break;
                case 22:
                    calendar.labelList.Add(calendar.Label23);
                    HelpSerialize(Convert.ToInt32(calendar.Label23.Content));
                    break;
                case 23:
                    calendar.labelList.Add(calendar.Label24);
                    HelpSerialize(Convert.ToInt32(calendar.Label24.Content));
                    break;
                case 24:
                    calendar.labelList.Add(calendar.Label25);
                    HelpSerialize(Convert.ToInt32(calendar.Label25.Content));
                    break;
                case 25:
                    calendar.labelList.Add(calendar.Label26);
                    HelpSerialize(Convert.ToInt32(calendar.Label26.Content));
                    break;
                case 26:
                    calendar.labelList.Add(calendar.Label27);
                    HelpSerialize(Convert.ToInt32(calendar.Label27.Content));
                    break;
                case 27:
                    calendar.labelList.Add(calendar.Label28);
                    HelpSerialize(Convert.ToInt32(calendar.Label28.Content));
                    break;

                default:
                    break;
            } 
        }

        private void TvNews(int tvNews)
        {

            var documen1 = File.ReadAllText($"D:/TvNews/Day{tvNews}.txt");
            MessageBox.Show(documen1);
        }

        private int HelpDeserialize()
        {
            string dayDerialized = File.ReadAllText(@"D:\JSON\DayofSesons.json");
            var dayDerializedFinal = JsonConvert.DeserializeObject<int>(dayDerialized);
            return dayDerializedFinal;
        }

        private void HelpSerialize(int bedClick_nextday)
        {
            string daySerialized = JsonConvert.SerializeObject(bedClick_nextday);
            File.WriteAllText(@"D:\JSON\DayofSesons.json", daySerialized);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
