using Microsoft.EntityFrameworkCore;
using Practice.Application;
using Practice.Domain.Repositories;
using Practice.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Infrastructure
{
	public class ApplicationUnitOfWork : UnitOfWork,IApplicationUnitOfWork
	{

		public ICourseRepository CourseRepository { get; private set; }
		public ApplicationUnitOfWork(DbContext dbContext) : base(dbContext)
		{
			CourseRepository = new CourseRepository(dbContext);
		}

		

		
	}
}
