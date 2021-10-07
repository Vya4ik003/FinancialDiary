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
        public string LogoPath { get; } = "pack://application:,,,/Diary.Commons;component/Resources/Logo.jpg";
        public Page CenterPage { get; set; }

        public IMenuControlViewModel MenuControlViewModel { get; set; }

        public MainWindowViewModel(IMenuControlViewModel menuControlViewModel, ICenterPageViewModel centerPageViewModel)
        {
            MenuControlViewModel = menuControlViewModel;
            CenterPage = new CenterPage(centerPageViewModel);
        }
    }
}
