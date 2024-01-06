using DDD_02.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD_02.Domain.Repositories;
using DDD_02.Domain.Entities;

namespace DDD_02.Infrastructure.Repositories
{
    public class CourseRepository : Repository<Course,Guid>, ICourseRepository
    {
        public CourseRepository(DbContext context) : base(context)
        {
        }
    }
}
