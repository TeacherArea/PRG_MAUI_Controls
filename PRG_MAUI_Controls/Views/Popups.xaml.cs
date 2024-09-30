namespace PRG_MAUI_Controls;

public partial class Popups : ContentPage
{
	public Popups()
	{
		InitializeComponent();
	}

    private async void GoToAlert(object sender, EventArgs e)
    {
        await DisplayAlert("Information", "Du klickade p� knappen f�r en alert!", "OK");
    }

    private async void GoToConfirm(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("V�lj mellan ...", "�r du s�ker?", "OK", "Avbryt");

        if (answer)
        {
        
        }
        
        else 
        { 
        
        }
    }

    private async void GoToPrompt(object sender, EventArgs e)
    {
        string name = await DisplayPromptAsync("Feed me ...", "Vad heter du?");

        if (!string.IsNullOrEmpty(name))
        {
            Console.WriteLine($"Hej {name}, kul att tr�ffas!");
        }
        
        else
        {

        }
    }
}