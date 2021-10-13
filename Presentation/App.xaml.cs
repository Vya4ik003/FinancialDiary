using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using Diary.Presentation.Views;
using Diary.Presentation.ViewModels.MainWindowViewModel;
using Diary.Presentation.ViewModels.MainPageViewModel;
using Diary.Controls.ViewModels.MenuControlViewModel;

namespace Diary.Presentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<IMainWindowViewModel, MainWindowViewModel>();

            services.AddSingleton<MainPage>();
            services.AddSingleton<IMainPageViewModel, MainPageViewModel>();

            services.AddSingleton<IMenuControlViewModel, MenuControlViewModel>();
        }

        public void OnStartup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }
}
