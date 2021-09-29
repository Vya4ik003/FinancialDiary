using System.Collections.Generic;
using Commons;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Linq;

namespace ControlsLibrary.ViewModels
{
    public class MenuControlViewModel : ViewModel
    {
        public ObservableCollection<TreeViewItem> TreeItems { get; set; }

        public MenuControlViewModel()
        {
            TreeItems = new ObservableCollection<TreeViewItem>
            {
                new TreeViewItem()
                    {
                        Header = "Развлечения",
                        ItemsSource = new List<TreeViewItem>
                        {
                            new TreeViewItem(){ Header = "Фаст-фуд" },
                            new TreeViewItem(){ Header = "Кино" },
                            new TreeViewItem(){ Header = "Аттракционы" },
                        }
                    },
                new TreeViewItem()
                    {
                        Header = "Продукты",
                        ItemsSource = new List<TreeViewItem>
                        {
                            new TreeViewItem(){ Header = "Продукты для дома" },
                            new TreeViewItem(){ Header = "Вкусняшки" },
                        }
                    },
                new TreeViewItem()
                    {
                        Header = "Одежда",
                        ItemsSource = new List<TreeViewItem>
                        {
                            new TreeViewItem(){ Header = "Одежда для детей" },
                            new TreeViewItem(){ Header = "Одежда для себя" },
                            new TreeViewItem(){ Header = "Одежда для попугая" },
                        }
                    }
            };
        }

        public RelayCommand AddCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    var element = new TreeViewItem() { Header = "Empty" };
                    TreeItems.Add(element);
                });
            }
        }

        public RelayCommand RemoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                TreeItems.Remove(TreeItems.Last()),
                (_) => TreeItems.Count > 0);
            }
        }
    }
}
