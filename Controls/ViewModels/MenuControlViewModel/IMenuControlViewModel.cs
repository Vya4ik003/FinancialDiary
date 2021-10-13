
using Diary.Commons;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Diary.Controls.ViewModels.MenuControlViewModel
{
    public interface IMenuControlViewModel
    {
        ObservableCollection<TreeViewItem> Items { get; set; }
        RelayCommand AddCategoryCommand { get; }
        RelayCommand RemoveCategoryCommand { get; }
    }
}
