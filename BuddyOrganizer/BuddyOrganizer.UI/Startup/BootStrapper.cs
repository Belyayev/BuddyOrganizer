using Autofac;
using BuddyOrganizer.UI.Data;
using BuddyOrganizer.UI.ViewModel;

namespace BuddyOrganizer.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<BuddyDataService>().As<IBuddyDataService>();

            return builder.Build();
        }
    }
}
