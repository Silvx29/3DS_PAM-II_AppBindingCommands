namespace AppBindingCommands
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DateTime data = DateTime.Now;
            Preferences.Set("dtActual", data);
            Preferences.Set("acaoInicial", string.Format("* App executado às {0}: \n", data));
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();
            Preferences.Set("AcaoStart", string.Format("* App iniciado às {0}. \n", DateTime.Now));
        }
        protected override void OnSleep()
        {
            base.OnSleep();
            Preferences.Set("OnSleep", string.Format("* App em segundo plano às {0}. \n", DateTime.Now));
        }
        protected override void OnResume()
        {
            base.OnResume();
            Preferences.Set("OnResume", string.Format("* App reativado às {0}. \n", DateTime.Now));
        }
        //comentario
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "AppBindingCommands" };
        }
    }
}
