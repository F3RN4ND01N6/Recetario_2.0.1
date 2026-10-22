using Recetario.Services;

namespace Recetario;

public partial class App : Application
{
    private readonly RecetaService _service;

    public App(RecetaService service)
    {
        InitializeComponent();
        UserAppTheme = AppTheme.Light;
        _service = service;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell(_service))
        {
            Title = "Raccolta di ricette — Recetario 2.0",
            Width = 1080,
            Height = 780
        };
    }
}
