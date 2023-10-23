using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikacja
{
    internal class SystemyLiczbowe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int liczbaDz;

        public int LiczbaDz
        {
            get { return liczbaDz; }
            set
            {
                liczbaDz = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("LiczbaDz"));
            }
        }

        private int wynikB;
  
        public int WynikB
        {
            get { return wynikB; }
            set
            {              
                wynikB = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("WynikB"));
            }
        }
        private int liczbaB;

        public int LiczbaB
        {
            get { return liczbaB; }
            set
            {
                liczbaB = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("LiczbaB"));
            }
        }
        private int wynikDz;

        public int WynikDz
        {
            get { return wynikDz; }
            set
            {
                wynikDz = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("WynikDz"));
            }
        }
        public SystemyLiczbowe()
        {
            LiczbaDz = 120;
            LiczbaB = 0101;
            WynikDz = 0;
            WynikB = 0;
        }
        public void zDznaB()
        {
            WynikB = 101010;
        }
    }   
}

