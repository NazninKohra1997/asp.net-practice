using DDD_01.Application;
using DDD_01.Domain.Repositories;
using DDD_01.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_01.Infrastructure
{
	public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
	{

		public ICourseRepository CourseRepository { get; private set; }
		public ApplicationUnitOfWork(ApplicationDbContext dbContext) : base(dbContext)
		{
			CourseRepository = new CourseRepository(dbContext);
		}

		

		
	}
}
