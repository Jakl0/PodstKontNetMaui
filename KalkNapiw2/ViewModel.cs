using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace KalkNapiw2
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private double kwota;
        private double procent;
        private int osoby;
        private double kwota_n;
        private double suma;
        private double kwota_o;

        public double Kwota
        {
            get => kwota;
            set
            {
                if (value != kwota)
                {
                    kwota = value;
                    Kwota_N = value * (procent / 100);
                    Kwota_O = Kwota_N + Kwota;
                    OnPropertyChanged("Kwota");
                }
            }
        }
        public double Procent
        {
            get => procent;
            set
            {
                if (value != procent)
                {
                    procent = value;

                    OnPropertyChanged("Procent");
                    Kwota_N = Kwota * (value / 100);

                }
            }
        }
        public int Osoby
        {
            get => osoby;
            set
            {
                if (value != osoby)
                {

                    osoby = value;
                    OnPropertyChanged("Osoby");
                    Suma = Kwota_O * value;
                }
            }
        }
        public double Suma
        {
            get => suma;
            set
            {
                if (value != suma)
                {
                    suma = value;
                    OnPropertyChanged("Suma");
                    
                }
            }
        }
        public double Kwota_N
        {
            get => kwota_n;
            set
            {
                if (value != kwota_n)
                {
                    kwota_n = value;
                    Kwota_O = value + Kwota;
                    OnPropertyChanged("Kwota_N");
                }
            }
        }
        public double Kwota_O
        {
            get => kwota_o;
            set
            {
                if (value != kwota_o)
                {
                    kwota_o = value;
                    Suma = value * Osoby;
                    OnPropertyChanged("Kwota_O");
                }
            }
        }
        public ViewModel()
        {
            SelectTen = new Command(ten);
            SelectFifteen = new Command(fiften);
            SelectTwenty = new Command(twenty);
            Kwota_N = 0;
            Kwota = 0;
            Kwota_O = 0;
            Osoby = 1;
            Procent = 0;
            Suma = 0;
        }
        public ICommand SelectTen { get; }
        public ICommand SelectFifteen { get; }
        public ICommand SelectTwenty { get; }
        public void ten()
        {
            Procent = 10;
        }
        public void fiften()
        {
            Procent = 15;
        }
        public void twenty()
        {
            Procent = 20;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
/*
 ************************************************************************************************* 
 
nazwa funkcji:        ten
opis funkcji:        funkcja ustawia wartość slidera na 10
parametry:           brak

zwracany typ:        brak
autor:               xxxxx



**************************************************************************************************
* ************************************************************************************************* 
 
nazwa funkcji:        fiften
opis funkcji:        funkcja ustawia wartość slidera na 15
parametry:           brak

zwracany typ:        brak
autor:               xxxxx



**************************************************************************************************
* ************************************************************************************************* 
 
nazwa funkcji:        twenty
opis funkcji:        funkcja ustawia wartość slidera na 20
parametry:           brak

zwracany typ:        brak
autor:               xxxxx



**************************************************************************************************
 */

