using Microsoft.EntityFrameworkCore;
using prac.Application;
using prac.Domain.Repositories;
using prac.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac.Infrastructure
{
	public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
	{
		public ApplicationUnitOfWork(DbContext dbContext) : base(dbContext)
		{
			CourseRepository = new CourseRepository(dbContext);
		}

		public ICourseRepository CourseRepository { get; private set; }

		
	}
}
