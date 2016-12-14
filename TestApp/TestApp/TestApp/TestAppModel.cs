using System;
using System.ComponentModel;


namespace TestApp
{
    class TestAppModel : INotifyPropertyChanged
    {
        double x, y, total;
        public event PropertyChangedEventHandler PropertyChanged;
        public double X
        {
            set
            {
                if (x != value)
                {
                    x = value;
                    OnPropertyChanged("X");
                    Recalculate();
                }
            }
            get
            {
                return x;
            }
        }

        public double Y
        {
            set
            {
                if (y != value)
                {
                    y = value;
                    OnPropertyChanged("Y");
                    Recalculate();
                }
            }
            get
            {
                return y;
            }
        }

        public double Total
        {
            set
            {
                if (total != value)
                {
                    total = value;
                    OnPropertyChanged("Total");
                }
            }
            get
            {
                return total;
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        void Recalculate()
        {
            // calcolo percentuale per la parte di ... es. 20 e 100 mi da incremento del 80
            // this.Total = 100-((x/y)*100);

            // calcolo per lo scostamento in valore assoluto:

            double centesimaParteDiX;
            double centesimePartiDiXCheStannoInY;

            centesimaParteDiX = x / 100;

            centesimePartiDiXCheStannoInY = y / centesimaParteDiX;

            this.Total = centesimePartiDiXCheStannoInY - 100;
           
        }
    }

}
