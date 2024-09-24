namespace PRG_MAUI_Controls;

public partial class Time : ContentPage
{
	public Time()
	{
		InitializeComponent();
	}

	private async void GoToStart(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//Main");
	}
}