using Autofac;
using Autofac_Configuration.Models;

namespace Autofac_Configuration
{
    public class WebModule :  Module   //here Module class is from autofac
    {
        protected override void Load(ContainerBuilder builder)   //this method is from go to defination
        {
            builder.RegisterType<UnicodeSmsSender>().As<ISmsSender>();
        }
    }
}
