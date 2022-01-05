using TeamFinder.ViewModels;

namespace TeamFinder
{
    public partial class MainWindow
    {
        public MainWindow(LoginScreenViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}