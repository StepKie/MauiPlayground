namespace MauiPlayground;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    /// <summary> See https://learn.microsoft.com/en-us/dotnet/maui/whats-new/dotnet-9?view=net-maui-9.0#mainpage </summary>
    protected override Window CreateWindow(IActivationState? activationState) => new(page: new AppShell());
}
