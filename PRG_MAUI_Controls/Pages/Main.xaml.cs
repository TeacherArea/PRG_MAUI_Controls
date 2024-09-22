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

        private async void GoToProgress(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Progress");
        }

        private async void GoToCollections(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Collections");
        }

        private async void GoToTime(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Time");
        }

        private async void GoToSwitches(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Switches");
        }

        private async void GoToForms(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Forms");
        }

        private async void GoToAnimations(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Animations");
        }
    }
}
