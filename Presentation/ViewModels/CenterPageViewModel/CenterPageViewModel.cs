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
            mediator.CenterPageColleague = this;
            ConcreteMediator = mediator;
        }

        public void Notify(object information)
        {
        }

        public void Send(object information)
        {
            ConcreteMediator.Send(information, this);
        }
    }
}
