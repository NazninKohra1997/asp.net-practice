using Microsoft.EntityFrameworkCore;
using project.Domain.Repositories;
using project.Infrastructure.Repositories;
using project.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.Application;


namespace project.Infrastructure
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public ApplicationUnitOfWork(ApplicationDbContext dbContext) : base(dbContext)
        {
            CourseRepository = new CourseRepository(dbContext);
        }

        public  ICourseRepository CourseRepository { get; private set; }


    }

   
}
