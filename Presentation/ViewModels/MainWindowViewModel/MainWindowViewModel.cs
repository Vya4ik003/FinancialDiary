using System.Windows.Controls;
using Diary.Presentation.Views;
using Diary.Presentation.ViewModels.CenterPageViewModel;
using Diary.Commons;
using Diary.Controls.ViewModels.MenuControlViewModel;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Diary.Presentation.ViewModels.MainWindowViewModel
{
    public class MainWindowViewModel : ViewModel, IMainWindowViewModel
    {
        public string LogoPath { get; } = "pack://application:,,,/Commons;component/Resources/Logo.jpg";
        public Page CenterPage { get; set; }

        private readonly IServiceProvider _serviceProvider;
        public IMenuControlViewModel MenuControlViewModel { get; set; }

        public MainWindowViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            MenuControlViewModel = _serviceProvider.GetRequiredService<IMenuControlViewModel>();
            ICenterPageViewModel centerPageViewModel = _serviceProvider.GetRequiredService<ICenterPageViewModel>();
            CenterPage = new CenterPage(centerPageViewModel);
        }
    }
}
