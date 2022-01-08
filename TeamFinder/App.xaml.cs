using System.Windows;
using Ninject;
using RestSharp;
using TeamFinder.Repository;

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

            container.Bind<RestClient>().ToConstant(new RestClient("http://localhost:8075/api"));
            container.Bind<IAuthRepository>().To<AuthRepository>();
        }

        private void ComposeObjects()
        {
            Current.MainWindow = container.Get<MainWindow>();
        }
    }
}