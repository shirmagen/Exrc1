using Caliburn.Micro;
using Exrc1.ViewModels;
using System.Windows;

namespace Exrc1
{
    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<FixButtonViewModel>();
        }
    }
}