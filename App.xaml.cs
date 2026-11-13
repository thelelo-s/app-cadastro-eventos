namespace CadastroEventos;
public partial class App : Application
{
    public App() => InitializeComponent();
    protected override Window CreateWindow(IActivationState? activationState)
        => new(new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromArgb("#155EAD"), BarTextColor = Colors.White });
}
