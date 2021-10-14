using System.ComponentModel;
using System.Runtime.CompilerServices;
using Diary.Commons.Mediator;
using Diary.Commons;

namespace Diary.Presentation.ViewModels.AddCategoryPageViewModel
{
    public class AddCategoryPageViewModel : IAddCategoryPageViewModel
    {
        private string _categoryName;
        public string CategoryName
        {
            get
            {
                return _categoryName;
            }
            set
            {
                _categoryName = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Send(CategoryName);
                }, (_) => CategoryName.Length > 0);
            }
        }

        public AddCategoryPageViewModel(IMediator mediator)
        {
            CategoryName = string.Empty;
            mediator.CenterPageColleague = this;
            Mediator = mediator;
        }

        #region IColleague implementation

        public IMediator Mediator { get; set; }

        public void Notify(object information)
        {

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
