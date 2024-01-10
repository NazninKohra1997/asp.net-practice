using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using System.Text;
using System.Threading.Tasks;
using prac.Application;

namespace prac.Infrastructure
{
	public class InfrastructureModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<ApplicationUnitOfWork>().As<IApplicationUnitOfWork>().InstancePerMatchingLifetimeScope();
		}
	}
}
