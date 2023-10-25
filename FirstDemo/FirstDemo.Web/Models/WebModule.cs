using Autofac;

namespace FirstDemo.Web.Models
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UniCodeSmsSender>().As<ISmsSender>();
        }
    }
}
