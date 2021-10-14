using Diary.Commons;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Diary.Controls.ViewModels.MenuControlViewModel
{
    public class MenuControlViewModel : ViewModel, IMenuControlViewModel
    {
        public ObservableCollection<TreeViewItem> Items { get; set; }

        public RelayCommand AddCategoryCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    
                });
            }
        }

        public RelayCommand RemoveCategoryCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    
                });
            }
        }
    }
}
