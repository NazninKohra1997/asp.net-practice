﻿using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using System.Text;
using System.Threading.Tasks;
using DDD_02.Application;
using DDD_02.Infrastructure.Repositories;
using DDD_02.Domain.Repositories;

namespace DDD_02.Infrastructure
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
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssembly", _migrationAssembly).InstancePerLifetimeScope();


            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
				.WithParameter("connectionString",_connectionString)
				.WithParameter("migrationAssembly",_migrationAssembly).InstancePerLifetimeScope();

            
			builder.RegisterType<ApplicationUnitOfWork>().As<IApplicationUnitOfWork>().InstancePerLifetimeScope();

			builder.RegisterType<CourseRepository>().As<ICourseRepository>().InstancePerLifetimeScope();
		}
	}
}
