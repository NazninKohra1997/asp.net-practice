using Autofac;
using prac.Application.Features.Training;
using prac.Domain.Features.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac.Application
{
	public class ApplicationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CourseManagementService>().As<ICourseManagementService>().InstancePerMatchingLifetimeScope();
		}
	}
}
