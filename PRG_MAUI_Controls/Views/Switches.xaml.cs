namespace PRG_MAUI_Controls;

public partial class Switches : ContentPage
{
    private bool isAlertDisplayed = false;
    public Switches()
    {
        InitializeComponent();
        SetDarkModeSwitchState();
    }

    void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        double newValue = e.NewValue;

        if (newValue > 85 && !isAlertDisplayed)
        {
            DisplayAlert("Information", $"Värdet börjar bli kritiskt: {newValue}!", "OK");
            isAlertDisplayed = true;
        }
        else if (newValue <= 75 && isAlertDisplayed)
        {
            isAlertDisplayed = false;
        }
    }

    void OnColorSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        double redValue = redSlider.Value;
        double greenValue = greenSlider.Value;
        double blueValue = blueSlider.Value;

        this.BackgroundColor = Color.FromRgb((int)redValue, (int)greenValue, (int)blueValue);

        colorCodeLabel.Text = $"RGB({(int)redValue}, {(int)greenValue}, {(int)blueValue})";
    }

    void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        double newValue = e.NewValue;

        if (newValue == 3)
        {
            DisplayAlert("Information", "Värdet är 3!", "OK");
        }

        if (newValue == 5)
        {
            StartButton.BackgroundColor = Colors.Red;
        }
        else
        {
            StartButton.BackgroundColor = Colors.Green;
        }
    }

    private async void GoToStart(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Main");
    }

    private void SetDarkModeSwitchState()
    {
        DarkModeSwitch.IsToggled = Application.Current.UserAppTheme == AppTheme.Dark;
    }

    void DarkMode(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Light;
        }
    }
}
