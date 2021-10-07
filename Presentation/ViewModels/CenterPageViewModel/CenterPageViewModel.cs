using Diary.Commons;
using Diary.Commons.Mediator;
using System.Windows;

namespace Diary.Presentation.ViewModels.CenterPageViewModel
{
    public class CenterPageViewModel : ViewModel, IColleague, ICenterPageViewModel
    {
        public IMediator ConcreteMediator { get; }

        public CenterPageViewModel(IMediator mediator)
        {
            mediator.Colleague1 = this;
            ConcreteMediator = mediator;
        }

        private bool _isEnabled = true;
        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }

        private int _radiusBlur = 0;
        public int RadiusBlur
        {
            get
            {
                return _radiusBlur;
            }
            set
            {
                _radiusBlur = value;
                OnPropertyChanged();
            }
        }

        private Visibility _visibility = Visibility.Collapsed;
        public Visibility Visibility
        {
            get
            {
                return _visibility;
            }
            set
            {
                _visibility = value;
                OnPropertyChanged();
            }
        }

        public void Notify(NotifyInformation information)
        {
            if (RadiusBlur == 0)
            {
                RadiusBlur = 10;
                IsEnabled = false;
                Visibility = Visibility.Visible;
            }
            else
            {
                IsEnabled = true;
                RadiusBlur = 0;
                Visibility = Visibility.Collapsed;
            }
        }

        public void Send(NotifyInformation information)
        {
            ConcreteMediator.Send(information, this);
        }
    }
}
