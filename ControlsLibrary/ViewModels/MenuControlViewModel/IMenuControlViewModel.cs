using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Diary.Controls.ViewModels.MenuControlViewModel
{
    public interface IMenuControlViewModel
    {
        public ObservableCollection<TreeViewItem> TreeItems { get; }
    }
}
