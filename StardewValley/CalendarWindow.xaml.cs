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




        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}




