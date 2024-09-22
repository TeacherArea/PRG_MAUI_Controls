namespace PRG_MAUI_Controls;

public partial class Text : ContentPage
{
	public Text()
	{
		InitializeComponent();
		ColoredText.TextColor = Color.FromRgba(255, 165, 80, 200); // 200 �r v�rdet p� det genomskinliga. 0 �r helt genomskinlig, och 255 helt full f�rg.
	}

	private async void GoToStart(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//Main");
	}
}