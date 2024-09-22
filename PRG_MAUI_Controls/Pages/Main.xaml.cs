namespace PRG_MAUI_Controls
{
    public partial class Main : ContentPage
    {
        int count = 0;

        public Main()
        {
            InitializeComponent();
        }
        private async void GoToText(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Text");
        }

        private async void GoToImages(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Images");
        }

        private async void GoToAlert(object sender, EventArgs e)
        {
            await DisplayAlert("Info", "Du klickade på fyrkanten!", "OK");
        }
    }
}
