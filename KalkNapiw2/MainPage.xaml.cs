namespace KalkNapiw2
{
    public partial class MainPage : ContentPage
    {
        int zmienna_pomocnicza;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel();
        }

        void onSwitched(object sender, EventArgs e)
        {
            PeopleEntry.IsVisible = (!PeopleEntry.IsVisible);
            if (PeopleEntry.IsVisible == false)
            {
                zmienna_pomocnicza = int.Parse(PeopleEntry.Text);
                PeopleEntry.Text = "1";
            }
            else
            {
                PeopleEntry.Text = $"{zmienna_pomocnicza}";
            }
        }
       
    }
}
/*
 ************************************************************************************************* 
 
nazwa funkcji:        onSwitched
opis funkcji:        funkcja obsługuje przełącznik który dzieli kwotę między ludzi jeśli jest włączony
parametry:           standardowe parametry w funkcjach net maui

zwracany typ:        brak
autor:               xxxxx



**************************************************************************************************
 */
