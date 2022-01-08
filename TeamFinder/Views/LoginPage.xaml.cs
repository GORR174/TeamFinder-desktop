using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using TeamFinder.ViewModels;

namespace TeamFinder.Views
{
    public partial class LoginPage : Page
    {
        private LoginPageViewModel _viewModel;
        
        public LoginPage(LoginPageViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = viewModel;
            viewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (_viewModel.IsSignedIn)
            {
                var window = (MainWindow) Window.GetWindow(this);
                
                window.NavigateToMainPage();
            }
        }
    }
}