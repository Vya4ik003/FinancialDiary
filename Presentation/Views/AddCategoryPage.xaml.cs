using System.Windows.Controls;
using Diary.Presentation.ViewModels.AddCategoryPageViewModel;

namespace Diary.Presentation.Views
{
    /// <summary>
    /// Interaction logic for AddCategoryPage.xaml
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
