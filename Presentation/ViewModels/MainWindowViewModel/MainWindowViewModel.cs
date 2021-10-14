using Diary.Commons;
using System.Windows.Controls;
using System;
using Microsoft.Extensions.DependencyInjection;
using Diary.Presentation.Views;
using Diary.Controls.ViewModels.MenuControlViewModel;

namespace Diary.Presentation.ViewModels.MainWindowViewModel
{
    public class MainWindowViewModel : ViewModel, IMainWindowViewModel
    {
        public IMenuControlViewModel MenuControlViewModel { get; set; }
        public IServiceProvider ServiceProvider { get; set; }

        private Page _centerPage;
        public Page CenterPage
        {
            get
            {
                return _centerPage;
            }
            set
            {
                _centerPage = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel(IServiceProvider _serviceProvider)
        {
            ServiceProvider = _serviceProvider;
            CenterPage = ServiceProvider.GetRequiredService<MainPage>();
            MenuControlViewModel = ServiceProvider.GetRequiredService<IMenuControlViewModel>();
        }

    }
}
