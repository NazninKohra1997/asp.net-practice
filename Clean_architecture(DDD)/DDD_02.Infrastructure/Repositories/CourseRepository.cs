using DDD_01.Application;
using DDD_01.Domain.Entities;
using DDD_01.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_02.Infrastructure.Repositories
{
    public class CourseRepository : Repository<Course, Guid>, ICourseRepository
    {
        public CourseRepository(DbContext context) : base(context)
        {
        }
    }
}
