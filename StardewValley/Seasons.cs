using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewValley
{
  public class Seasons : INotifyPropertyChanged
    {
        private string _seasonsName;
        public string  seasonsName {
            get { return _seasonsName; }
            set
            {
                _seasonsName = value;
                if (PropertyChanged !=null)
                PropertyChanged(this, new PropertyChangedEventArgs("PartOfSeasons"));
            } 
        }
        public int seasonsDay { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
