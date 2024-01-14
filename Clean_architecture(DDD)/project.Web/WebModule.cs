using Autofac;
using project.Web.Areas.Admin.Models;

namespace project.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseCreateModel>().AsSelf();
        }
    }
}
