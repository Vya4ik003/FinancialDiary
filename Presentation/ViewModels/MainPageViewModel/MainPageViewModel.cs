using System.ComponentModel;
using System.Runtime.CompilerServices;
using Diary.Commons.Mediator;

namespace Diary.Presentation.ViewModels.MainPageViewModel
{
    public class MainPageViewModel : IMainPageViewModel
    {
        public MainPageViewModel(IMediator mediator)
        {
            mediator.CenterPageColleague = this;
            Mediator = mediator;
        }

        #region IColleague implementation

        public IMediator Mediator { get; set; }

        public void Notify(object information)
        {

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
