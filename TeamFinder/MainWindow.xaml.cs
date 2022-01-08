using System.Windows.Controls;
using Ninject;
using TeamFinder.Views;

namespace TeamFinder
{
    public partial class MainWindow
    {
        private IKernel _container;
        public MainWindow(IKernel container)
        {
            InitializeComponent();
            _container = container;
            NavigateToPage(container.Get<LoginPage>());
        }

        public void NavigateToMainPage() => NavigateToPage(_container.Get<MainPage>());

        public void NavigateToPage(Page page)
        {
            MainFrame.NavigationService.Navigate(page);
        }
    }
}