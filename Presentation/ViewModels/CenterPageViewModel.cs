using Commons;
using Commons.Mediator;

namespace Presentation.ViewModels
{
    public class CenterPageViewModel : ViewModel, IColleague
    {
        public IMediator ConcreteMediator { get; }

        public CenterPageViewModel()
        {
            Mediator.ConcreteMediator.Colleague1 = this;
            ConcreteMediator = Mediator.ConcreteMediator;
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

        public RelayCommand ClickCommand
        {
            get
            {
                return null;
            }
        }

        public void Notify(NotifyInformation information)
        {
            if (RadiusBlur == 0)
            {
                RadiusBlur = 10;
                IsEnabled = false;
            }
            else
            {
                IsEnabled = true;
                RadiusBlur = 0;
            }
        }

        public void Send(NotifyInformation information)
        {
            ConcreteMediator.Send(information, this);
        }
    }
}
