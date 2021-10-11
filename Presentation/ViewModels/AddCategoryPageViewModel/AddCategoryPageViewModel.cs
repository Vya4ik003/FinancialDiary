using Diary.Commons.Mediator;
using Diary.Commons;

namespace Diary.Presentation.ViewModels.AddCategoryPageViewModel
{
    public class AddCategoryPageViewModel : ViewModel, IColleague, IAddCategoryPageViewModel
    {
        public IMediator ConcreteMediator { get; set; }

        public AddCategoryPageViewModel(IMediator mediator)
        {
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
