namespace TaskProgresser.MAUI_Blazor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "TaskProgresser.MAUI_Blazor" };
        }
    }
}
