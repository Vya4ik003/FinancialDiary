using System.Windows.Controls;
using Presentation.Views;
using Commons;

namespace Presentation.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public string LogoPath { get; } = "../Resources/Logo.jpg";
        public Page CenterPage { get; set; }

        public MainWindowViewModel()
        {
            CenterPage = new CenterPage();
        }
    }
}
