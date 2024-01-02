using DDD_01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_01.Domain.Repositories
{
    public interface ICourseRepository : IRepositoryBase<Course, Guid>
    {

    }
}
