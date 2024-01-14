using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using System.Text;
using System.Threading.Tasks;
using prac.Application;
using prac.Infrastructure.Repositories;
using prac.Domain.Repositories;

namespace prac.Infrastructure
{
	public class InfrastructureModule : Module
	{
		private readonly string _connectionString;
		private readonly string _migrationAssembly;

		public InfrastructureModule(string connectionString, string migrationAssembly)
		{
			_connectionString = connectionString;
			_migrationAssembly = migrationAssembly;
		}

	
		protected override void Load(ContainerBuilder builder)
		{
            builder.RegisterType<ApplicationDbContext>().AsSelf()
				.WithParameter("connectionString",_connectionString)
				.WithParameter("migrationAssembly",_migrationAssembly).InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
               .WithParameter("connectionString", _connectionString)
               .WithParameter("migrationAssembly", _migrationAssembly).InstancePerLifetimeScope();

            builder.RegisterType<ApplicationUnitOfWork>().As<IApplicationUnitOfWork>().InstancePerLifetimeScope();
			builder.RegisterType<CourseRepository>().As<ICourseRepository>().InstancePerLifetimeScope();
			
		}
	}
}
