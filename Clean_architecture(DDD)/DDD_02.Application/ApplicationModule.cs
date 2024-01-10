using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DDD_02.Application.Features.Training;
using DDD_02.Domain.Features.Training;

namespace DDD_02.Application
{
	public class ApplicationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CourseManagementService>().As<ICourseManagementService>().InstancePerMatchingLifetimeScope();
		}
	}
}
