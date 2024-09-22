namespace PRG_MAUI_Controls;

public partial class Text : ContentPage
{
	public Text()
	{
		InitializeComponent();
		ColoredText.TextColor = Color.FromRgba(255, 165, 80, 200); // 200 är värdet på det genomskinliga. 0 är helt genomskinlig, och 255 helt full färg.
	}
}