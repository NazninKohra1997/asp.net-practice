using Autofac;
using DDD_01.Application.Features.Training;
using DDD_01.Domain.Features.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_01.Application
{
	public class ApplicationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CourseManagementService>().As<ICourseManagementService>().InstancePerLifetimeScope();
			

		}
	}
}
