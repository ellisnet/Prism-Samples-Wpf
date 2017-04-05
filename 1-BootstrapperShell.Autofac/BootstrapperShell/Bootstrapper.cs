using Autofac;
using Prism.Autofac;
using BootstrapperShell.Views;
using System.Windows;

namespace BootstrapperShell
{
    class Bootstrapper : AutofacBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
