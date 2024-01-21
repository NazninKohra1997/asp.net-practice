using Autofac;
using Course.Web.Areas.Admin.Models;

namespace Course.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseCreateModel>().AsSelf();
        }
    }
}
