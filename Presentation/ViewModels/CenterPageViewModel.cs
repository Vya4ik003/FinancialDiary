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
                return new RelayCommand((_) =>
                {
                    //Send(new NotifyInformation(ActionTypes.AddCategory, new[] { 0 }));
                    //if (RadiusBlur == 0)
                    //    RadiusBlur = 10;
                    //else
                    //    RadiusBlur = 0;
                });
            }
        }

        public void Notify(NotifyInformation information)
        {
            if (RadiusBlur == 0)
                RadiusBlur = 10;
            else
                RadiusBlur = 0;
        }

        public void Send(NotifyInformation information)
        {
            ConcreteMediator.Send(information, this);
        }
    }
}
