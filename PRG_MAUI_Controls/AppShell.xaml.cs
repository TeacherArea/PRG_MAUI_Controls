namespace PRG_MAUI_Controls
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Progress", typeof(Progress));
            Routing.RegisterRoute("Collections", typeof(Collections));
            Routing.RegisterRoute("Time", typeof(Time));
            Routing.RegisterRoute("Switches", typeof(Switches));
            Routing.RegisterRoute("Animations", typeof(Animations));
            Routing.RegisterRoute("Forms", typeof(Forms));
        }
    }
}
