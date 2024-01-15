using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.Application;
using project.Infrastructure;
using project.Infrastructure.Repositories;
using project.Domain.Repositories;

namespace project.Infrastructure
{
   public class InfrastructureModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssesmbly;

        public InfrastructureModule(string connectionString, string migrationAssesmbly)
        {
            _connectionString = connectionString;
			_migrationAssesmbly = migrationAssesmbly;
        }
        protected override void Load(ContainerBuilder builder)
        {
			builder.RegisterType<ApplicationDbContext>().AsSelf()
			   .WithParameter("connectionString", _connectionString)
			   .WithParameter("migrationAssembly", _migrationAssesmbly).InstancePerLifetimeScope();

			builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("connectionString",_connectionString)
                .WithParameter("migrationAssembly",_migrationAssesmbly).InstancePerLifetimeScope();


            builder.RegisterType<ApplicationUnitOfWork>().As<IApplicationUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<CourseRepository>().As<ICourseRepository>().InstancePerLifetimeScope();
        }
    }
}
