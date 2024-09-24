namespace PRG_MAUI_Controls

{

	public partial class Images : ContentPage
	{
		public Images()
		{
			InitializeComponent();
		}

        private async void TappedImage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Main");
        }
    }
}