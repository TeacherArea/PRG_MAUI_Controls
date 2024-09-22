namespace PRG_MAUI_Controls;

public partial class Animations : ContentPage
{
	public Animations()
	{
		InitializeComponent();
	}

	private async void GoToStart(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//Main");
	}
}