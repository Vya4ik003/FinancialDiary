using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using Diary.Presentation.Views;
using Diary.Presentation.ViewModels.MainWindowViewModel;
using Diary.Presentation.ViewModels.MainPageViewModel;
using Diary.Controls.ViewModels.MenuControlViewModel;
using Diary.Commons.Mediator;
using Diary.Presentation.ViewModels.AddCategoryPageViewModel;

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
            services.AddScoped<MainWindow>();
            services.AddScoped<IMainWindowViewModel, MainWindowViewModel>();

            services.AddScoped<MainPage>();
            services.AddScoped<IMainPageViewModel, MainPageViewModel>();

            services.AddScoped<IMenuControlViewModel, MenuControlViewModel>();

            services.AddScoped<AddCategoryPage>();
            services.AddScoped<IAddCategoryPageViewModel, AddCategoryPageViewModel>();

            services.AddSingleton<IMediator, Mediator>();
        }

        public void OnStartup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }
}
