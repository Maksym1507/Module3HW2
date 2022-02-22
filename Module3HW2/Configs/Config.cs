using Autofac;
using Module3HW2.Interfaces;
using Module3HW2.Services;

namespace Module3HW2.Configs
{
    public class Config
    {
        public IContainer RegisterTypes()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<NotificationService>().As<INotificationService>();
            builder.RegisterType<AlphabetConfigurationService>().As<IAlphabetConfigurationService>();
            builder.RegisterType<ContactListService>().As<IContactListService>();
            builder.RegisterType<Starter>();
            return builder.Build();
        }
    }
}
