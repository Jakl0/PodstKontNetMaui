using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Zadanie2PodstawoweKontrolki
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel();
        }



        public void onZapisz(object sender, EventArgs e)
        {
            string message = "";
            

            if (push.IsToggled || email.IsToggled || SMS.IsToggled)
            {
                message += "Powiadomienia:{";

                if (push.IsToggled)
                    message += " push";
                if (email.IsToggled)
                    message += " email";
                if (SMS.IsToggled)
                    message += " SMS";

                message += " ;}";
            }
            else
            {
                message += "Powiadomienia: nic;";
            }

            if (dane_analityczne.IsChecked || pers_reklamy.IsChecked)
            {
                message += " Prywatność:{";

                if (dane_analityczne.IsChecked)
                    message += " Dane analityczne";
                if (pers_reklamy.IsChecked)
                    message += " Personalizowane Reklamy";


                message += " ;}";
            }
            else
            {
                message += " Prywatność: nic;";
            }
            message += $" Wygląd: Rozmiar czcionki ({sliderrr.Value:F0})";
            if (darkmode.IsToggled)
            {
                message += " ,tryb ciemny włączony;";
            }
            else
                message += " ,tryb ciemny wyłączony;";
            DisplayAlert("Ustawienia Zapisane Pomyślnie",message,"Ok");
        }
        public void onReset(object sender, EventArgs e)
        {
            sliderrr.Value = 16;

            SMS.IsToggled = false;
            email.IsToggled = false;
            push.IsToggled = false;

            pers_reklamy.IsChecked = false;
            dane_analityczne.IsChecked = false;

            darkmode.IsToggled = false;
        }


        }
    }
/*
    ******************************************************************************************** 
 
nazwa funkcji:        onZapisz
opis funkcji:        Funkcja wyświetla komunikat zawierający informacje o opcjach wybranych przez użytkownika
parametry:           podstawowe parametry net maui

zwracany typ:        brak
autor:               xxxxx



*************************************************************************************************
 */

