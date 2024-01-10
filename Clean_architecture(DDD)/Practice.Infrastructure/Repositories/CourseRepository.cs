using Microsoft.EntityFrameworkCore;
using Practice.Domain.Entities;
using Practice.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Infrastructure.Repositories
{
	public class CourseRepository : Repository<Course, Guid>, ICourseRepository
	{
		public CourseRepository(DbContext context) : base(context)
		{
		}
	}
}
