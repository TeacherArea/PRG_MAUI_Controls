using Microsoft.Maui.Graphics;

namespace PRG_MAUI_Controls;

public partial class Forms : ContentPage
{
	public Forms()
	{
		InitializeComponent();
	}

	private async void GoToStart(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//Main");
	}
}