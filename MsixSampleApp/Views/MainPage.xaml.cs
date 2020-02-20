using System.Windows.Controls;

using MsixSampleApp.ViewModels;

namespace MsixSampleApp.Views
{
    public partial class MainPage : Page
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
