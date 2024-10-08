﻿namespace PRG_MAUI_Controls
{
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void GoToInOutput(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Inoutput");
        }

        private async void GoToText(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Text");
        }

        private async void GoToPopups(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Popups");
        }
        
        private async void GoToImages(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Images");
        }

        private async void GoToProgress(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Progress");
        }

        private async void GoToCollections(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Collections");
        }
        private async void GoToTime(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Time");
        }

        private async void GoToSwitches(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Switches");
        }

        private async void GoToForms(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Forms");
        }
        private async void GoToAnimations(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Animations");
        }
    }
}
