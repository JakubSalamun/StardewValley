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
using System.Windows.Shapes;

namespace StardewValley
{
    /// <summary>
    /// Interaction logic for CalendarWindow.xaml
    /// </summary>
    public partial class CalendarWindow : Window
    {
        public List<Label> labelList = new List<Label>();


        public CalendarWindow()
        {
        
            InitializeComponent();


            labelList.Add(Label1);
            labelList.Add(Label2);
            labelList.Add(Label3);
            labelList.Add(Label4);
            labelList.Add(Label5);
            labelList.Add(Label6);
            labelList.Add(Label7);
            labelList.Add(Label8);
            labelList.Add(Label9);
            labelList.Add(Label10);
            labelList.Add(Label11);
            labelList.Add(Label12);
            labelList.Add(Label13);
            labelList.Add(Label14);
            labelList.Add(Label15);
            labelList.Add(Label16);
            labelList.Add(Label17);
            labelList.Add(Label18);
            labelList.Add(Label19);
            labelList.Add(Label20);
            labelList.Add(Label21);
            labelList.Add(Label22);
            labelList.Add(Label23);
            labelList.Add(Label24);
            labelList.Add(Label25);
            labelList.Add(Label26);
            labelList.Add(Label27);
            labelList.Add(Label28);


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}




