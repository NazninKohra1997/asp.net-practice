using Autofac;
using Practice.Application.Features.Training;
using Practice.Domain.Features.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application
{
	public class ApplicationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CourseManagementService>().As<ICourseManagementService>().InstancePerLifetimeScope();
		}
	}
}
