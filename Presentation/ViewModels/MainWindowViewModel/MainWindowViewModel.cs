using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System;
using Microsoft.Extensions.DependencyInjection;
using Diary.Presentation.Views;
using Diary.Controls.ViewModels.MenuControlViewModel;
using Diary.Commons.Mediator;
using Diary.Commons.Mediator.Information;
using Diary.Presentation.ViewModels.AddCategoryPageViewModel;
using Diary.Presentation.ViewModels.MainPageViewModel;

namespace Diary.Presentation.ViewModels.MainWindowViewModel
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        public IMenuControlViewModel MenuControlViewModel { get; set; }
        public IServiceProvider ServiceProvider { get; set; }


        public MainWindowViewModel(IServiceProvider _serviceProvider)
        {
            ServiceProvider = _serviceProvider;

            CenterPage = ServiceProvider.GetRequiredService<MainPage>();
            MenuControlViewModel = ServiceProvider.GetRequiredService<IMenuControlViewModel>();

            IMediator mediator = ServiceProvider.GetRequiredService<IMediator>();
            mediator.MainWindowColleague = this;
            Mediator = mediator;
        }

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

        #region IColleague implementation

        public IMediator Mediator { get; set; }

        public void Notify(object information)
        {
            MenuActions action = (MenuActions)information;

            if(action == MenuActions.AddCategory)
            {
                CenterPage = ServiceProvider.GetRequiredService<AddCategoryPage>();
                Mediator.CenterPageColleague = ServiceProvider.GetRequiredService<IAddCategoryPageViewModel>();
            }
            if(action == MenuActions.HideCenterPage)
            {
                CenterPage = ServiceProvider.GetRequiredService<MainPage>();
                Mediator.CenterPageColleague = ServiceProvider.GetRequiredService<IMainPageViewModel>();
            }
        }

        public void Send(object information)
        {

        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
