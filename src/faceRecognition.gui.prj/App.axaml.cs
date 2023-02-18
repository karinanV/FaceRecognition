using System;

using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using Avalonia.ReactiveUI;
using Avalonia.Controls.ApplicationLifetimes;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

using ReactiveUI;

using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;

using FaceRecognition.Gui.ViewModels;
using FaceRecognition.Gui.Views;
using FaceRecognition.Common.Services.IconProvider;

namespace FaceRecognition.Gui;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public IServiceProvider Container { get; private set; }

    public App()
    {
        var host = Host
            .CreateDefaultBuilder()
            .ConfigureServices(service =>
            {
                service.UseMicrosoftDependencyResolver();
                service
                    .AddSingleton<IApplicationIconProvider>(provider =>
                    {
                        var assets = Container.GetRequiredService<IAssetLoader>();
                        return new ApplicationIconProvider(assets, $"avares://faceRecognition.gui/Assets/avalonia-logo.ico");
                    });


				var resolver = Locator.CurrentMutable;
                resolver.InitializeSplat();
                resolver.InitializeReactiveUI();

                RxApp.MainThreadScheduler = AvaloniaScheduler.Instance;
            })
            .Build();

        Container = host.Services;
        Container.UseMicrosoftDependencyResolver();
        host.Start();
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if(ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            if(CheckActivation())
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel()
                    {
                        
                    }
                };
            }
        }

        base.OnFrameworkInitializationCompleted();
    }

    private bool CheckActivation() => true;

}