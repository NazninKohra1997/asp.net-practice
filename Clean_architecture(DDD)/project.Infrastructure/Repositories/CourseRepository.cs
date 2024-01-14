using Microsoft.EntityFrameworkCore;
using project.Domain.Entities;
using project.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Infrastructure.Repositories
{
	public class CourseRepository : Repository<Course, Guid>, ICourseRepository
	{
		public CourseRepository(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
