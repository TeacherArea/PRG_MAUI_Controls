namespace PRG_MAUI_Controls;

public partial class Collections : ContentPage
{
	public Collections()
	{
		InitializeComponent();
	}

	private async void GoToStart(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//Main");
	}
}