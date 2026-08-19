namespace AppBindingCommands
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnatualizarInformacoes_Clicked(object sender, EventArgs e)
        {
            string informacoes = string.Empty;

            if (Preferences.ContainsKey("AcaoInicial"))
                informacoes += Preferences.Get("AcaoInicial", string.Empty);
            if (Preferences.ContainsKey("AcaoInicial"))
                informacoes += Preferences.Get("AcaoInicial", string.Empty);
            if (Preferences.ContainsKey("AcaoInicial"))
                informacoes += Preferences.Get("AcaoInicial", string.Empty);
            if (Preferences.ContainsKey("AcaoInicial"))
                informacoes += Preferences.Get("AcaoInicial", string.Empty);
            if (Preferences.ContainsKey("AcaoInicial"))
        }
    }
}
