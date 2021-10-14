using Diary.Commons;
using System.Collections.ObjectModel;
using Diary.Commons.Mediator;
using System.Windows.Controls;
using System.Linq;
using System.ComponentModel;
using Diary.Commons.Mediator.Information;
using System.Runtime.CompilerServices;

namespace Diary.Controls.ViewModels.MenuControlViewModel
{
    public class MenuControlViewModel : IMenuControlViewModel
    {
        public ObservableCollection<TreeViewItem> Items { get; set; }

        public MenuControlViewModel(IMediator mediator)
        {
            Items = new ObservableCollection<TreeViewItem>();
            mediator.MenuControlColleague = this;
            Mediator = mediator;
        }

        public RelayCommand AddCategoryCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    MenuActions action = MenuActions.AddCategory;
                    Send(action);
                });
            }
        }

        public RelayCommand RemoveCategoryCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Items.Remove(Items.Last());
                }, (_) => Items.Count > 0);
            }
        }

        #region IColleague implementation

        public IMediator Mediator { get; set; }

        public void Notify(object information)
        {
            string category = information as string;
            Items.Add(new TreeViewItem { Header = category });

            MenuActions action = MenuActions.HideCenterPage;
            Send(action);
        }

        public void Send(object information)
        {
            Mediator.Send(information, this);
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
