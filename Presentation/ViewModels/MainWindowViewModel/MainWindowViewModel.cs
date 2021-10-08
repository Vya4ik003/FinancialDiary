using System.Windows.Controls;
using Diary.Presentation.Views;
using Diary.Presentation.ViewModels.CenterPageViewModel;
using Diary.Commons;
using Diary.Controls.ViewModels.MenuControlViewModel;
using Diary.Commons.Mediator;

namespace Diary.Presentation.ViewModels.MainWindowViewModel
{
    public class MainWindowViewModel : ViewModel, IMainWindowViewModel, IColleague
    {
        public string LogoPath { get; } = "pack://application:,,,/Diary.Commons;component/Resources/Logo.jpg";
        public Page CenterPage { get; set; }
        public IMediator ConcreteMediator { get; set; }

        public IMenuControlViewModel MenuControlViewModel { get; set; }

        public MainWindowViewModel(IMenuControlViewModel menuControlViewModel, ICenterPageViewModel centerPageViewModel, IMediator mediator)
        {
            MenuControlViewModel = menuControlViewModel;
            CenterPage = new CenterPage(centerPageViewModel);
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
