using Microsoft.EntityFrameworkCore;
using prac.Domain.Entities;
using prac.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac.Infrastructure.Repositories
{
    public class CourseRepository : Repository<Course,Guid>, ICourseRepository
    {
        public CourseRepository(DbContext context) : base(context)
        {
        }
    }
}
