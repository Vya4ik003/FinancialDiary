using System.Windows.Controls;
using Diary.Presentation.ViewModels.MainPageViewModel;

namespace Diary.Presentation.Views
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage(IMainPageViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
