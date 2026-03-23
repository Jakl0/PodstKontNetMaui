namespace zadanie1podstawowekontrolki
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void wyswietlAlert(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(nameEntry.Text)&& !string.IsNullOrEmpty(messageEditor.Text) && !string.IsNullOrEmpty(titleEntry.Text) && !string.IsNullOrEmpty(secondEntry.Text) && !string.IsNullOrEmpty(mailEntry.Text))
            { 
            DisplayAlert("Wysłano", "Wiadomość została wysłana", "OK");
            mailEntry.Text = string.Empty;
            nameEntry.Text = string.Empty;
            secondEntry.Text = string.Empty;
            titleEntry.Text = string.Empty;
            messageEditor.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Błąd","Należy wypełnić wszystkie Pola","OK");
            }
        }
        
    }
}
