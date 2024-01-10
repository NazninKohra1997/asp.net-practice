using Autofac;
using prac.Web.Areas.Admin.Models;

namespace prac.Web
{
	public class WebModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CourseCreateModel>().AsSelf();
		}
	}
}
