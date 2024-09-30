namespace PRG_MAUI_Controls;

public partial class Popups : ContentPage
{
	public Popups()
	{
		InitializeComponent();
	}

    private async void GoToAlert(object sender, EventArgs e)
    {
        await DisplayAlert("Information", "Du klickade på knappen för en alert!", "OK");
    }

    private async void GoToConfirm(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Välj mellan ...", "Är du säker?", "OK", "Avbryt");

        if (answer)
        {
            ShowResponsLabel.Text = $"Du tryckte på \"OK\" vilket returnerade: {answer}";
        }
        
        else 
        {
            ShowResponsLabel.Text = $"Du tryckte på \"Avbryt/Cancel\" vilket returnerande: {answer}";
        }
    }

    private async void GoToPrompt(object sender, EventArgs e)
    {
        string name = await DisplayPromptAsync("Feed me ...", "Vad heter du?");

        if (!string.IsNullOrEmpty(name))
        {
            ShowResponsLabel.Text = $"Hej {name}, kul att träffas!";
        }
        
        else
        {
            ShowResponsLabel.Text = $"Du tryckte på \"Avbryt/Cancel\" vilket inte returnerade något.";
        }
    }
}