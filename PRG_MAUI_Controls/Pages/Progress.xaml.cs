namespace PRG_MAUI_Controls;

public partial class Progress : ContentPage
{
	public Progress()
	{
		InitializeComponent();
	}

	private async void GoToStart(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//Main");
	}
}