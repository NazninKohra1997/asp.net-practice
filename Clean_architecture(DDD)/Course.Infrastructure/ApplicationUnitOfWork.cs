using Course.Application;
using Course.Domain.Repositories;
using Course.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Infrastructure
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
