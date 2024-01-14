using DDD_02.Application;
using DDD_02.Domain.Repositories;
using DDD_02.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_02.Infrastructure
{
	public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
	{
		public ApplicationUnitOfWork(ApplicationDbContext dbContext) : base(dbContext)
		{
			CourseRepository = new CourseRepository(dbContext);
		}

		public ICourseRepository CourseRepository { get; private set; }

		
	}
}
