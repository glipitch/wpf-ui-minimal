using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TrailerDesktop;

public partial class App
{
    private static readonly IHost _host = Host.CreateDefaultBuilder()
        .ConfigureServices(
            (context, services) =>
            {
                services.AddSingleton<MainWindow>();
                services.AddSingleton<MainWindowViewModel>();
            }
        )
        .Build();

    private void OnStartup(object sender, StartupEventArgs e) =>
        _host.Services.GetRequiredService<MainWindow>().Show();

    private async void OnExit(object sender, ExitEventArgs e)
    {
        await _host.StopAsync();
        _host.Dispose();
    }
}
