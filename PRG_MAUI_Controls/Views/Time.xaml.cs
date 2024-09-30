namespace PRG_MAUI_Controls;

public partial class Time : ContentPage
{
	string originalTextTimeLabel = "";
	string originalTextDateLabel = "";

    public Time()
	{
		InitializeComponent();

		timePickerControl.Time = DateTime.Now.TimeOfDay;

		originalTextTimeLabel = SelectedTimeLabel.Text;
		originalTextDateLabel = SelectedDateLabel.Text;
	}

	private void ShowSelectedDateTime(object sender, EventArgs e)
	{
		DateTime dateTime = datePickerControl.Date;
		TimeSpan timeSpan = timePickerControl.Time;

		SelectedDateLabel.Text = $"Valt datum är: {dateTime.ToString("D")}";
		SelectedTimeLabel.Text = $"Vald tid är: {timeSpan}";
	}

    private void ResetSelectedDateTime(object sender, EventArgs e)
    {
        timePickerControl.Time = DateTime.Now.TimeOfDay;
		datePickerControl.Date = DateTime.Now.Date;
		SelectedDateLabel.Text = originalTextDateLabel;
		SelectedTimeLabel.Text = originalTextTimeLabel;
    }

    private async void GoToStart(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//Main");
	}
}