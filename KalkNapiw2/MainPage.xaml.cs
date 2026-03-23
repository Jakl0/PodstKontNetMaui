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
