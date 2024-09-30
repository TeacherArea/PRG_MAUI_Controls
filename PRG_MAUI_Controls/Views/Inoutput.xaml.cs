namespace PRG_MAUI_Controls;

public partial class Inoutput : ContentPage
{
    private TodoViewModel viewModel;

    public Inoutput()
    {
        InitializeComponent();

        viewModel = new TodoViewModel();
        BindingContext = viewModel;
    }

    private void OnSwipeEnded(object sender, SwipeEndedEventArgs e)
    {
        if (e.IsOpen)
        {
            var swipeView = (SwipeView)sender;
            var item = swipeView.BindingContext as string;

            if (item != null && viewModel.RemoveTodoCommand.CanExecute(item))
            {
                viewModel.RemoveTodoCommand.Execute(item);
            }
        }
    }

    private void ShowSomethingButton(object sender, EventArgs e)
    {
        string userInput = EntryForUserInput.Text;
        ShowLabel.Text = userInput;
        EntryForUserInput.Text = "";
    }

    private async void TappedImage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Main");
    }
}
