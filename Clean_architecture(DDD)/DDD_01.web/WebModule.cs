using Autofac;
using DDD_01.web.Areas.Admin.Models;

namespace DDD_01.web
{
	public class WebModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CourseCreateModel>().AsSelf();
		}
	}
}
