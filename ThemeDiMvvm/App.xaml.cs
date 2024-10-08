﻿using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ThemedDiMvvm;

public partial class App
{
    private static readonly IHost _host = Host.CreateDefaultBuilder()
        .ConfigureServices(
            (context, services) =>
            {
                services.AddSingleton<MainWindow>();
                services.AddSingleton<MainViewModel>();
            }
        )
        .Build();

    private void Application_Startup(object sender, StartupEventArgs e)
    {
        _host.Start();
        _host.Services.GetRequiredService<MainWindow>().Show();
    }
}
