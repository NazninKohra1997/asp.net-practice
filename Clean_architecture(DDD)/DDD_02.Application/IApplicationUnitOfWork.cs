using DDD_02.Domain;
using DDD_02.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_02.Application
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
         ICourseRepository CourseRepository { get; set; }
    }
}
