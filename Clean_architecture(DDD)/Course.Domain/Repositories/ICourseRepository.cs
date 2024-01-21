using Course.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Domain.Repositories
{
    public interface ICourseRepository : IRepositoryBase<Courses,Guid>
    {

    }
}
