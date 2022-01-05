using System.Windows;
using Ninject;

namespace TeamFinder
{
    public partial class App
    {
        private IKernel container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {
            container = new StandardKernel();
        }

        private void ComposeObjects()
        {
            Current.MainWindow = container.Get<MainWindow>();
        }
    }
}