namespace PRG_MAUI_Controls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            #if WINDOWS
                window.Width = 480;
                window.Height = 800;
            #endif

            return window;
        }

    }
}