using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace PRG_MAUI_Controls
{
    public partial class Progress : ContentPage
    {
        private bool _isRunning; 
        private bool _isPaused; 
        private int loopProgress = 0; 

        public Progress()
        {
            InitializeComponent();
        }

        private async void StartLoop(object sender, EventArgs e)
        {
            _isRunning = true;
            _isPaused = false;
            StartLoopButton.IsEnabled = false;
            PauseLoopButton.IsEnabled = true;
            ResetLoopButton.IsEnabled = false;

            ActivityIndicatorControl.IsRunning = true;
            ActivityIndicatorControl.Opacity = 1;

            int totalSteps = 100;
            double totalWidth = this.Width - 40;

            for (int i = loopProgress; i <= totalSteps && _isRunning; i++)
            {
                if (_isPaused) break;

                ProgressBarControl.Progress = (double)i / totalSteps;

                double progressWidth = totalWidth * ((double)i / totalSteps);
                
                ProgressBarFill.WidthRequest = progressWidth;

                await Task.Delay(200); // 0,5 sekunders fördröjning
                loopProgress++;
            }

            if (!_isPaused && loopProgress > totalSteps)
            {
                PauseLoopButton.IsEnabled = false;
                ResetLoopButton.IsEnabled = true;
                await ExplodeActivityIndicator();

                ActivityIndicatorControl.IsRunning = false;
                ActivityIndicatorControl.Opacity = 0;
            }
        }

        private void PauseLoop(object sender, EventArgs e)
        {
            _isRunning = false;
            _isPaused = true;

            StartLoopButton.IsEnabled = true;
            PauseLoopButton.IsEnabled = false;
            ResetLoopButton.IsEnabled = true;
        }

        private void ResetLoop(object sender, EventArgs e)
        {
            _isRunning = false;
            _isPaused = false;
            loopProgress = 0;
            ProgressBarControl.Progress = 0;
            ProgressBarFill.WidthRequest = 0; 
            StartLoopButton.IsEnabled = true;
            PauseLoopButton.IsEnabled = false;
            ResetLoopButton.IsEnabled = false;
            ActivityIndicatorControl.Opacity = 0;
            ActivityIndicatorControl.Scale = 1;
        }

        private async Task ExplodeActivityIndicator()
        {
            await ActivityIndicatorControl.ScaleTo(3, 500);
            await ActivityIndicatorControl.FadeTo(0, 250);
        }

        private async void GoToStart(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Main");
        }
    }
}
