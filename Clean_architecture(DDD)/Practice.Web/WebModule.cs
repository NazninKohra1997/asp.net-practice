using Autofac;
using Practice.Web.Models;

namespace Practice.Web
{
	public class WebModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CourseCreateModel>().AsSelf();
		}
	}
}
