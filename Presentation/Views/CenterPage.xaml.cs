using System.Windows.Controls;
using Diary.Presentation.ViewModels.CenterPageViewModel;

namespace Diary.Presentation.Views
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class CenterPage : Page
    {
        public CenterPage(ICenterPageViewModel centerPageViewModel)
        {
            InitializeComponent();
            DataContext = centerPageViewModel;
        }
    }
}
