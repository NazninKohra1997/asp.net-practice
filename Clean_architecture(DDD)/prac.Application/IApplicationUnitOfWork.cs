using prac.Application.Features.Training;
using prac.Domain;
using prac.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac.Application
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        ICourseRepository CourseRepository { get; set; }
    }
}
