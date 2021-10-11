using System.Windows.Controls;
using Diary.Presentation.Views;
using Diary.Presentation.ViewModels.CenterPageViewModel;
using Diary.Commons;
using Diary.Controls.ViewModels.MenuControlViewModel;
using Diary.Commons.Mediator;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Diary.Presentation.ViewModels.MainWindowViewModel
{
    public class MainWindowViewModel : ViewModel, IMainWindowViewModel, IColleague
    {
        public string LogoPath { get; } = "pack://application:,,,/Diary.Commons;component/Resources/Logo.jpg";
        public Page CenterPage { get; set; }
        public IServiceProvider _serviceProvider;
        public IMediator ConcreteMediator { get; set; }
        public IMenuControlViewModel MenuControlViewModel { get; set; }

        public MainWindowViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            MenuControlViewModel = _serviceProvider.GetRequiredService<IMenuControlViewModel>();
            ICenterPageViewModel centerPageViewModel = _serviceProvider.GetRequiredService<ICenterPageViewModel>();
            CenterPage = new CenterPage(centerPageViewModel);
            IMediator mediator = _serviceProvider.GetRequiredService<IMediator>();
            mediator.MainWindowColleague = this;
            ConcreteMediator = mediator;
        }

        public void Notify(object notifyInformation)
        {

        }

        public void Send(object notifyInformation)
        {
            ConcreteMediator.Send(notifyInformation, this);
        }
    }
}
