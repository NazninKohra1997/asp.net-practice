using Autofac;
using DDD_02.Web.Areas.Admin.Models;

namespace DDD_02.Web
{
	public class WebModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CourseCreateModel>().AsSelf();
		}
	}
}
