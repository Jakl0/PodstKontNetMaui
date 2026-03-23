using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Zadanie2PodstawoweKontrolki
{
    internal class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private int fontsaiz;
        public int FontSaiz
        {
            get => fontsaiz;
            set
            {
                if (fontsaiz != value)
                {
                    fontsaiz = value;
                    OnPropertyChanged("FontSaiz");
                }
            }
        }
        public ViewModel()
        {
            fontsaiz = 16;
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
