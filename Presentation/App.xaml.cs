using System;
using System.Windows;
using Diary.Presentation.Views;
using Diary.Controls.ViewModels.MenuControlViewModel;
using Diary.Presentation.ViewModels.CenterPageViewModel;
using Diary.Presentation.ViewModels.MainWindowViewModel;
using Microsoft.Extensions.DependencyInjection;
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
            services.AddSingleton<MainWindow>();
            services.AddSingleton<IMainWindowViewModel, MainWindowViewModel>();
            services.AddSingleton<ICenterPageViewModel, CenterPageViewModel>();
            services.AddSingleton<IMenuControlViewModel, MenuControlViewModel>();
            services.AddSingleton<IAddCategoryPageViewModel, AddCategoryPageViewModel>();
            services.AddSingleton<IMediator, Mediator>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
