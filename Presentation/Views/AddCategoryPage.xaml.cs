using System.Windows.Controls;
using Diary.Presentation.ViewModels.AddCategoryPageViewModel;

namespace Diary.Presentation.Views
{
    /// <summary>
    /// Логика взаимодействия для AddCategoryPage.xaml
    /// </summary>
    public partial class AddCategoryPage : Page
    {
        public AddCategoryPage(IAddCategoryPageViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
