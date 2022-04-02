using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StardewValley
{
  public class Methods
    {
        CalendarWindow calendar = new CalendarWindow();
        public void HelpCurentDay(int help)
        {
            var help_d = HelpDeserialize();
            calendar.DataContext = help_d.seasonsName;
            string seasonsTime_Contetnt = calendar.SeasonsTime.Content.ToString();


            switch (help)
            {
                case 1:
                    calendar.labelList.Add(calendar.Label2);
                    HelpSerialize(Convert.ToInt32(calendar.Label2.Content),
                        calendar.SeasonsTime.Content.ToString());
                    break;
                case 2:
                    calendar.labelList.Add(calendar.Label3);
                    HelpSerialize(Convert.ToInt32(calendar.Label3.Content), seasonsTime_Contetnt);
                    break;
                case 3:
                    calendar.labelList.Add(calendar.Label4);
                    HelpSerialize(Convert.ToInt32(calendar.Label4.Content), seasonsTime_Contetnt);
                    break;
                case 4:
                    calendar.labelList.Add(calendar.Label5);
                    HelpSerialize(Convert.ToInt32(calendar.Label5.Content), seasonsTime_Contetnt);
                    break;
                case 5:
                    calendar.labelList.Add(calendar.Label6);
                    HelpSerialize(Convert.ToInt32(calendar.Label6.Content), seasonsTime_Contetnt);
                    break;
                case 6:
                    calendar.labelList.Add(calendar.Label7);
                    HelpSerialize(Convert.ToInt32(calendar.Label7.Content), seasonsTime_Contetnt);
                    break;
                case 7:
                    calendar.labelList.Add(calendar.Label8);
                    HelpSerialize(Convert.ToInt32(calendar.Label8.Content), seasonsTime_Contetnt);
                    break;
                case 8:
                    calendar.labelList.Add(calendar.Label9);
                    HelpSerialize(Convert.ToInt32(calendar.Label9.Content), seasonsTime_Contetnt);
                    break;
                case 9:
                    calendar.labelList.Add(calendar.Label10);
                    HelpSerialize(Convert.ToInt32(calendar.Label10.Content), seasonsTime_Contetnt);
                    break;
                case 10:
                    calendar.labelList.Add(calendar.Label11);
                    HelpSerialize(Convert.ToInt32(calendar.Label11.Content), seasonsTime_Contetnt);
                    break;

                case 11:
                    calendar.labelList.Add(calendar.Label12);
                    HelpSerialize(Convert.ToInt32(calendar.Label12.Content), seasonsTime_Contetnt);
                    break;
                case 12:
                    calendar.labelList.Add(calendar.Label13);
                    HelpSerialize(Convert.ToInt32(calendar.Label13.Content), seasonsTime_Contetnt);
                    break;
                case 13:
                    calendar.labelList.Add(calendar.Label14);
                    HelpSerialize(Convert.ToInt32(calendar.Label14.Content), seasonsTime_Contetnt);
                    break;
                case 14:
                    calendar.labelList.Add(calendar.Label15);
                    HelpSerialize(Convert.ToInt32(calendar.Label15.Content), seasonsTime_Contetnt);
                    break;
                case 15:
                    calendar.labelList.Add(calendar.Label16);
                    HelpSerialize(Convert.ToInt32(calendar.Label16.Content), seasonsTime_Contetnt);
                    break;
                case 16:
                    calendar.labelList.Add(calendar.Label17);
                    HelpSerialize(Convert.ToInt32(calendar.Label17.Content), seasonsTime_Contetnt);
                    break;
                case 17:
                    calendar.labelList.Add(calendar.Label18);
                    HelpSerialize(Convert.ToInt32(calendar.Label18.Content), seasonsTime_Contetnt);
                    break;
                case 18:
                    calendar.labelList.Add(calendar.Label19);
                    HelpSerialize(Convert.ToInt32(calendar.Label19.Content), seasonsTime_Contetnt);
                    break;
                case 19:
                    calendar.labelList.Add(calendar.Label20);
                    HelpSerialize(Convert.ToInt32(calendar.Label20.Content), seasonsTime_Contetnt);
                    break;
                case 20:
                    calendar.labelList.Add(calendar.Label21);
                    HelpSerialize(Convert.ToInt32(calendar.Label21.Content), seasonsTime_Contetnt);
                    break;
                case 21:
                    calendar.labelList.Add(calendar.Label22);
                    HelpSerialize(Convert.ToInt32(calendar.Label22.Content), seasonsTime_Contetnt);
                    break;
                case 22:
                    calendar.labelList.Add(calendar.Label23);
                    HelpSerialize(Convert.ToInt32(calendar.Label23.Content), seasonsTime_Contetnt);
                    break;
                case 23:
                    calendar.labelList.Add(calendar.Label24);
                    HelpSerialize(Convert.ToInt32(calendar.Label24.Content), seasonsTime_Contetnt);
                    break;
                case 24:
                    calendar.labelList.Add(calendar.Label25);
                    HelpSerialize(Convert.ToInt32(calendar.Label25.Content), seasonsTime_Contetnt);
                    break;
                case 25:
                    calendar.labelList.Add(calendar.Label26);
                    HelpSerialize(Convert.ToInt32(calendar.Label26.Content), seasonsTime_Contetnt);
                    break;
                case 26:
                    calendar.labelList.Add(calendar.Label27);
                    HelpSerialize(Convert.ToInt32(calendar.Label27.Content), seasonsTime_Contetnt);
                    break;
                case 27:
                    calendar.labelList.Add(calendar.Label28);
                    HelpSerialize(Convert.ToInt32(calendar.Label28.Content), seasonsTime_Contetnt);
                    break;
                case 28:
                    //ustawic Binding na calendar.SeasonsTime.Content by zmieniało Content 
                    //po kliknięciu na łóżko w dniu 28 ma zmienić pore sezonową i ustawić HelpCurentDay na 1 w nowym sezonie.
                    //
                    HelpSerialize(29, seasonsTime_Contetnt);
                    break;

                default:
                    break;
            }
        }

        public void TvNews(int tvNews)
        {

            var documen1 = File.ReadAllText($"C:/Users/Komputer/source/repos/StardewValley/StardewValley/TvNews/Day{tvNews}.txt");
            MessageBox.Show(documen1);
        }

        public Seasons HelpDeserialize()
        {
            string dayDerialized = File.ReadAllText(@"D:\JSON\DayofSesons.json");
            var dayDerializedFinal = JsonConvert.DeserializeObject<Seasons>(dayDerialized);
            return dayDerializedFinal;
        }

        public void HelpSerialize(int bedClick_nextday, string seasonsName)
        {
            Seasons seasons = new Seasons();
            seasons.seasonsName = seasonsName;
            seasons.seasonsDay = bedClick_nextday;
            string daySerialized = JsonConvert.SerializeObject(seasons);
            File.WriteAllText(@"D:\JSON\DayofSesons.json", daySerialized);
        }

        public void HelpSezons()
        {
            var help = HelpDeserialize();
            calendar.DataContext = help.seasonsName;

            if (help.seasonsName == "Spring" && help.seasonsDay == 29)
            {
                var serializationSummer = help.seasonsName = (calendar.DataContext = "Summer").ToString();
                var serializationSummerDay = help.seasonsDay = 1;
                HelpSerialize(serializationSummerDay, serializationSummer);
            }
            if (help.seasonsName == "Summer" && help.seasonsDay == 29)
            {
                var serializationFall = help.seasonsName = (calendar.DataContext = "Fall").ToString();
                var serializationFallDay = help.seasonsDay = 1;
                HelpSerialize(serializationFallDay, serializationFall);
            }
            if (help.seasonsName == "Fall" && help.seasonsDay == 29)
            {
                var serializationWinter = help.seasonsName = (calendar.DataContext = "Winter").ToString();
                var serializationWinterDay = help.seasonsDay = 1;
                HelpSerialize(serializationWinterDay, serializationWinter);
            }
            if (help.seasonsName == "Winter" && help.seasonsDay == 29)
            {
                var serializationSpring = help.seasonsName = (calendar.DataContext = "Spring").ToString();
                var serializationSpringDay = help.seasonsDay = 1;
                HelpSerialize(serializationSpringDay, serializationSpring);
            }
        }
    }
}
