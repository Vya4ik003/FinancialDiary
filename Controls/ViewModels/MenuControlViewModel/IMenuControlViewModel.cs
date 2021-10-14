using System.ComponentModel;
using Diary.Commons;
using Diary.Commons.Mediator;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Diary.Controls.ViewModels.MenuControlViewModel
{
    public interface IMenuControlViewModel : INotifyPropertyChanged, IColleague
    {
        ObservableCollection<TreeViewItem> Items { get; set; }
        RelayCommand AddCategoryCommand { get; }
        RelayCommand RemoveCategoryCommand { get; }
    }
}
