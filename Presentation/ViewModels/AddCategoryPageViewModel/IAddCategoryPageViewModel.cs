using Diary.Commons.Mediator;
using System.ComponentModel;
using Diary.Commons;

namespace Diary.Presentation.ViewModels.AddCategoryPageViewModel
{
    public interface IAddCategoryPageViewModel : INotifyPropertyChanged, IColleague
    {
        string CategoryName { get; set; }

        RelayCommand AddCommand { get; }
    }
}
